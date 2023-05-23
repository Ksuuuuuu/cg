using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab1
{
    public partial class MainForm : Form
    {
        private Bitmap image;
        private Bitmap ellipse;
        private Color Border_Color = Color.Aqua;
        private Graphics grafics;
        private int height_ellipse = 50;
        private int width_ellipse = 100;
        public MainForm()
        {
            InitializeComponent();
            image = new Bitmap(Properties.Resources.teksture);
            ellipse = new Bitmap(width_ellipse+1, height_ellipse+1);
            grafics = Graphics.FromImage(ellipse);
        }

        public void Color_Pixel(int x, int y, int i, int j) {
            Color pixel_el = ellipse.GetPixel(x, y);
            Color pixel_im = image.GetPixel(i, j);
            if (pixel_el.ToArgb() == Border_Color.ToArgb() || pixel_el.ToArgb() == pixel_im.ToArgb())
            {
                return;
            }
            ellipse.SetPixel(x, y, image.GetPixel(i, j));
            Color_Pixel(x, y + 1, i, j + 1);
            Color_Pixel(x + 1, y, i + 1, j);
            Color_Pixel(x - 1, y, i - 1, j);
            Color_Pixel(x, y - 1, i, j - 1);   
        }

        private void sheet_Click(object sender, EventArgs e)
        {
            grafics.DrawEllipse(new Pen(Border_Color), new Rectangle(0, 0, width_ellipse, height_ellipse));
            int i = image.Width / 2;//image i pixel
            int j = image.Height / 2;//image j pixel
            int x = width_ellipse / 2;
            int y = height_ellipse / 2;

            Color_Pixel(x, y, i, j);
            sheet.Image = ellipse;
        }

    }
}
