using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        {
            for (int y = 0; y < image.Height; y++)
            {
                Color pixelColor = image.GetPixel(x, y);
                int binaryrgb = (int)(pixelColor.R + pixelColor.G + pixelColor.B);
                if (binaryrgb < threshold)
                    image.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                else
                    image.SetPixel(x, y, Color.FromArgb(255, 255, 255));
            }
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
                image.SetPixel(x, y, Color.FromArgb(piexlColor.R, gray, gray));
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
