using System;
using System.Drawing;

public class imageProcesser
{
	private string _fileName;
	private Bitmap _image;

	public void _setFile(string filename)
	{
		this._fileName = filename;
		_image = new Bitmap(_fileName);
	}

	public Bitmap _getImage()
	{
		return _image;
	}

	// 二值化
	public Bitmap _binary(int threshold)
	{
		Bitmap image = (Bitmap)_image.Clone();
		for (int x = 0; x < image.Width; x++)
			for (int y = 0; y < image.Height; y++)
			{
				Color pixelColor = image.GetPixel(x, y);
				int binaryrgb = (int)(pixelColor.R + pixelColor.G + pixelColor.B);
				if (binaryrgb < threshold)
					image.SetPixel(x, y, Color.FromArgb(0, 0, 0));
				else
					image.SetPixel(x, y, Color.FromArgb(255, 255, 255));
			}
		return image;
	}

	// 灰階處理
	public Bitmap _gray()
	{
		Bitmap image = (Bitmap)_image.Clone();
		int gray;
		for (int x = 0; x < image.Width; x++)
		{
			for (int y = 0; y < image.Height; y++)
			{
				Color piexlColor = image.GetPixel(x, y);
				gray = piexlColor.R * 299 + piexlColor.G * 587 + piexlColor.B * 114;
				gray = gray / 1000;
				image.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
			}
		}
		return image;
	}

	// 保留色
	public Bitmap _reserve()
	{
		Bitmap image = (Bitmap)_image.Clone();
		int gray;
		for (int x = 0; x < image.Width; x++)
		{
			for (int y = 0; y < image.Height; y++)
			{
				Color piexlColor = image.GetPixel(x, y);
				gray = piexlColor.R * 299 + piexlColor.G * 587 + piexlColor.B * 114;
				gray = gray / 1000;
				if (piexlColor.R < piexlColor.G + piexlColor.B)
					image.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
			}
		}
		return image;
	}

	// 浮雕
	public Bitmap _relief()
	{
		Bitmap image = (Bitmap)_image.Clone();
		for (int x = 0; x < image.Width - 1; x++)
		{
			for (int y = 0; y < image.Height - 1; y++)
			{
				int r, g, b;
				Color originPixel = image.GetPixel(x, y);
				Color nextPixel = image.GetPixel(x + 1, y + 1);
				r = StandardPixel(Math.Abs(originPixel.R - nextPixel.R + 128));
				g = StandardPixel(Math.Abs(originPixel.G - nextPixel.G + 128));
				b = StandardPixel(Math.Abs(originPixel.B - nextPixel.B + 128));

				image.SetPixel(x, y, Color.FromArgb(r, g, b));
			}
		}
		return image;
	}

	// 避免Pixel溢出 正規化數值
	public int StandardPixel(int value)
	{
		value = Math.Min(255, value);
		value = Math.Max(0, value);
		return value;
	}

	// 模糊
	public Bitmap _blur(int radius)
	{
		Bitmap image = (Bitmap)_image.Clone();
		// 模糊是將附近的像素點設成鄰近的數值
		for (int yOffset = 0; yOffset < image.Height; yOffset++)
		{
			for (int xOffset = 0; xOffset < image.Width; xOffset++)
			{
				int averageR = 0, averageG = 0, averageB = 0;
				int blurCount = 0;
				for (int x = xOffset; (x < xOffset + radius && x < image.Width); x++)
				{
					for (int y = yOffset; (y < yOffset + radius && y < image.Height); y++)
					{
						Color piexlColor = image.GetPixel(x, y);
						averageR += piexlColor.R;
						averageG += piexlColor.G;
						averageB += piexlColor.B;
						blurCount++;
					}
				}

				averageR = averageR / blurCount;
				averageG = averageG / blurCount;
				averageB = averageB / blurCount;
				for (int x = xOffset; (x < xOffset + radius && x < image.Width); x++)
				{
					for (int y = yOffset; (y < yOffset + radius && y < image.Height); y++)
					{
						image.SetPixel(x, y, Color.FromArgb(averageR, averageG, averageB));
					}
				}
			}
		}
		return image;
	}

	//	銳化
	public Bitmap _crispening()
	{
		Bitmap image = (Bitmap)_image.Clone();
		Color pixelColor;
		int[] Laplacian = new int[] { -1, -1, -1, -1, 9, -1, -1, -1, -1 };

		for (int x = 1; x < image.Width - 1; x++)
			for (int y = 1; y < image.Height - 1; y++)
			{
				int r = 0, g = 0, b = 0;
				int index = 0;
				for (int column = -1; column <= 1; column++)
					for (int row = -1; row <= 1; row++)
					{
						pixelColor = image.GetPixel(x + row, y + column);
						r += pixelColor.R * Laplacian[index];
						g += pixelColor.G * Laplacian[index];
						b += pixelColor.B * Laplacian[index];
						index++;
					}
				r = StandardPixel(r);
				g = StandardPixel(g);
				b = StandardPixel(b);
				image.SetPixel(x, y, Color.FromArgb(r, g, b));
			}

		return image;
	}

	// 馬賽克
	public Bitmap _piexlization(int radius)
	{
		Bitmap image = (Bitmap)_image.Clone();
		// offset += radius
		// 馬賽克是將範圍區塊都設成相同的值
		for (int yOffset = 0; yOffset < image.Height; yOffset += radius)
		{
			for (int xOffset = 0; xOffset < image.Width; xOffset += radius)
			{
				int averageR = 0, averageG = 0, averageB = 0;
				int blurCount = 0;
				for (int x = xOffset; (x < xOffset + radius && x < image.Width); x++)
				{
					for (int y = yOffset; (y < yOffset + radius && y < image.Height); y++)
					{
						Color piexlColor = image.GetPixel(x, y);
						averageR += piexlColor.R;
						averageG += piexlColor.G;
						averageB += piexlColor.B;
						blurCount++;
					}
				}

				averageR = averageR / blurCount;
				averageG = averageG / blurCount;
				averageB = averageB / blurCount;
				for (int x = xOffset; (x < xOffset + radius && x < image.Width); x++)
				{
					for (int y = yOffset; (y < yOffset + radius && y < image.Height); y++)
					{
						image.SetPixel(x, y, Color.FromArgb(averageR, averageG, averageB));
					}
				}
			}
		}
		return image;
	}

	// 負片
	public Bitmap _invert()
	{
		Bitmap image = (Bitmap)_image.Clone();
		for (int x = 0; x < image.Width; x++)
		{
			for (int y = 0; y < image.Height; y++)
			{
				Color piexlColor = image.GetPixel(x, y);
				image.SetPixel(x, y, Color.FromArgb(255 - piexlColor.R, 255 - piexlColor.G, 255 - piexlColor.B));
			}
		}
		return image;
	}

	//去背
	public Bitmap _greenScreen(Color remove)
	{
		Bitmap image = (Bitmap)_image.Clone();
		for (int x = 0; x < image.Width; x++)
		{
			for (int y = 0; y < image.Height; y++)
			{
				Color piexlColor = image.GetPixel(x, y);
				if (remove == piexlColor)
					image.SetPixel(x, y, Color.LightGray);
			}
		}
		return image;
	}
}