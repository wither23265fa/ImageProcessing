using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace imageProcess
{
    public partial class mainForm : Form
    {
        //image processer object
        public imageProcesser _imgProcesser;
        private Color _colorPixel;
        private double _wr = 0.0, _hr = 0.0;
        public mainForm()
        {
            
            InitializeComponent();
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAfter.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            _imgProcesser = new imageProcesser();
        }

        private void img_MouseClick(object sender, MouseEventArgs e)
        {
            int width = _imgProcesser._getImage().Width;
            int height = _imgProcesser._getImage().Height;
                     
            if ((e.X < width) && (e.Y < height))
            {                            
                _colorPixel = _imgProcesser._getImage().GetPixel((int)(e.X * _wr ), (int)(e.Y * _hr));                           
                colorBox.BackColor = _colorPixel;                         
            }
        }

        private void updateImage(Bitmap image, int num)
        {
            if (num == 0)
                pictureBox.Image = image;
            else
                pictureBoxAfter.Image = image;
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _imgProcesser._setFile(fileDialog.FileName);
                updateImage(_imgProcesser._getImage(),0);
                //比例 size normal = 360
                _wr = (double)_imgProcesser._getImage().Width / 400;
                _hr = (double)_imgProcesser._getImage().Height / 400;               
            }
        }

        private void binButton_Click(object sender, EventArgs e)
        {
            updateImage(_imgProcesser._binary(Int32.Parse(trackTextBox.Text)), 1);
        }

        private void grayButton_Click(object sender, EventArgs e)
        {
            updateImage(_imgProcesser._gray(), 1);
        }     

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            trackTextBox.Text = trackBar.Value.ToString();
        }

        private void stoneButton_Click(object sender, EventArgs e)
        {
			updateImage(_imgProcesser._relief(), 1);
        }

        private void negativeButton_Click(object sender, EventArgs e)
        {
            updateImage(_imgProcesser._invert(), 1);
        }

        private void gaussButton_Click(object sender, EventArgs e)
        {
			updateImage(_imgProcesser._blur(2), 1);
        }

        private void laplasButton_Click(object sender, EventArgs e)
        {
			updateImage(_imgProcesser._crispening(), 1);
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            updateImage(_imgProcesser._reserve(), 1);
        }

        private void bgButton_Click(object sender, EventArgs e)
        {
            updateImage(_imgProcesser._greenScreen(colorBox.BackColor), 1);
        }

        private void masaicButton_Click(object sender, EventArgs e)
        {
			updateImage(_imgProcesser._piexlization(5), 1);
        }      
    }
}
