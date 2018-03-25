using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace image_processing
{
    public partial class Form1 : Form
    {
        int[,] imageInput;
        private Bitmap f_image = null;
        public Bitmap image;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "bitmap (*.bmp)|*.bmp";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (f_image != null) f_image.Dispose();
                    f_image = (Bitmap)Bitmap.FromFile(openFileDialog1.FileName, false);

                }
                catch (Exception)
                {
                    MessageBox.Show("Can not open file", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            }
            image = new Bitmap(f_image.Width, f_image.Height);
            imageInput = new int[f_image.Width, f_image.Height];
            for (int i = 0; i < f_image.Height; i++)
            {
                for (int j = 0; j < f_image.Width; j++)
                {
                    Color PixelColor = f_image.GetPixel(j, i);
                    int C_gray = (int)(PixelColor.R + PixelColor.G + PixelColor.B) / 3;
                    imageInput[j, i] = C_gray;
                    //  num_pic.Add(C_gray);
                    image.SetPixel(j, i, Color.FromArgb(C_gray, C_gray, C_gray));

                }
            }
            pictureBox1.Image = f_image;
            pictureBox2.Image = image;
        }

        public int[,] colorInArray()
        {
            int[,] colorPic = new int[f_image.Width, f_image.Height];
            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {
                    Color PixelColor = f_image.GetPixel(i, j);
                    int C_gray = (int)(PixelColor.R + PixelColor.G +
                    PixelColor.B) / 3;
                    colorPic[i, j] = C_gray;
                }
            }
            return colorPic;
        }

        private void btn_mean_filter_Click(object sender, EventArgs e)
        {
            int q = Convert.ToInt32(txt_Q.Text);

            image = new Bitmap(f_image.Width, f_image.Height);
            int[,] colorPic = new int[f_image.Width, f_image.Height];
            colorPic = colorInArray();

            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {
                    if (i == 0 || j == 0 || i == f_image.Width - 1 || j == f_image.Height - 1)
                    {
                        image.SetPixel(i, j, Color.FromArgb(colorPic[i, j], colorPic[i, j], colorPic[i, j]));
                    }
                    else
                    {
                        double sumtop = 0, sumbot = 0;
                        int newColor = 0;
                        for (int x = i - 1; x <= i; x++)
                        {
                            for (int y = j - 1; y <= j; y++)
                            {
                                Color PixelColor = f_image.GetPixel(x, y);
                                int C_gray = (int)(PixelColor.R + PixelColor.G + PixelColor.B) / 3;
                                if (C_gray != 0)
                                {
                                    sumbot += (double)Math.Pow(C_gray, q);
                                    sumtop += (double)Math.Pow(C_gray, q + 1);
                                }
                            }
                        }

                        try
                        {
                            newColor = Convert.ToInt32(Math.Round(sumtop / sumbot));

                        }
                        catch (Exception ex)
                        {
                            newColor = 0;
                        }

                        image.SetPixel(i, j, Color.FromArgb(newColor, newColor, newColor));
                    }

                }
            }
            pictureBox2.Image = image;

        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < f_image.Height - 1; i++)
            {
                for (int j = 1; j < f_image.Width - 1; j++)
                {
                    Color PixelColor = f_image.GetPixel(j, i);
                    int C_gray = (int)(PixelColor.R + PixelColor.G + PixelColor.B) / 3;
                    imageInput[j, i] = C_gray;
                    //  num_pic.Add(C_gray);
                    int max = Int32.MinValue;
                    for (int m = i - 1; m < i + 2; m++)
                    {
                        for (int n = j - 1; n < j + 2; n++)
                        {
                            if (imageInput[n, m] > max)
                            {
                                max = imageInput[n, m];
                            }
                        }
                    }
                    image.SetPixel(j, i, Color.FromArgb(max, max, max));
                }
            }

            pictureBox2.Image = image;
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < f_image.Height - 1; i++)
            {
                for (int j = 1; j < f_image.Width - 1; j++)
                {
                    Color PixelColor = f_image.GetPixel(j, i);
                    int C_gray = (int)(PixelColor.R + PixelColor.G + PixelColor.B) / 3;
                    imageInput[j, i] = C_gray;
                    //  num_pic.Add(C_gray);
                    int min = Int32.MaxValue;
                    for (int m = i - 1; m < i + 2; m++)
                    {
                        for (int n = j - 1; n < j + 2; n++)
                        {
                            if (imageInput[n, m] < min)
                            {
                                min = imageInput[n, m];
                            }
                        }
                    }
                    image.SetPixel(j, i, Color.FromArgb(min, min, min));
                }
            }

            pictureBox2.Image = image;
        }

        private void btn_midpoint_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < f_image.Height - 1; i++)
            {
                for (int j = 1; j < f_image.Width - 1; j++)
                {
                    Color PixelColor = f_image.GetPixel(j, i);
                    int C_gray = (int)(PixelColor.R + PixelColor.G + PixelColor.B) / 3;
                    imageInput[j, i] = C_gray;
                    //  num_pic.Add(C_gray);
                    int max = Int32.MinValue;
                    int min = Int32.MaxValue;
                    int mid = 0;
                    for (int m = i - 1; m < i + 2; m++)
                    {
                        for (int n = j - 1; n < j + 2; n++)
                        {
                            if (imageInput[n, m] > max)
                            {
                                max = imageInput[n, m];
                            }
                            if (imageInput[n, m] < min)
                            {
                                min = imageInput[n, m];
                            }
                        }
                        mid = (max + min) / 2;
                    }
                    image.SetPixel(j, i, Color.FromArgb(mid, mid, mid));
                }
            }

            pictureBox2.Image = image;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int d = Convert.ToInt16(txt_d.Text);
            image = new Bitmap(f_image.Width, f_image.Height);
            int[,] colorPic = new int[f_image.Width, f_image.Height];
            colorPic = colorInArray();

            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {
                    if (i == 0 || j == 0 || i == f_image.Width - 1 || j == f_image.Height - 1)
                    {
                        image.SetPixel(i, j, Color.FromArgb(colorPic[i, j], colorPic[i, j], colorPic[i, j]));
                    }
                    else
                    {
                        int[] values = { colorPic[i-1,j-1],colorPic[i-1, j],colorPic[i-1, j+1],
                            colorPic[i, j-1],colorPic[i, j],colorPic[i, j+1],
                            colorPic[i+1, j-1], colorPic[i+1, j], colorPic[i+1, j+1] };

                        Array.Sort(values);
                        int sum = 0;
                        int pop = d / 2;
                        for (int k = pop; k < values.Length - pop; k++)
                        {
                            sum += values[k];
                        }
                        sum = sum / (9 - d);
                        image.SetPixel(i, j, Color.FromArgb(sum, sum, sum));
                    }

                }
            }
            pictureBox2.Image = image;
        }
    }
}
