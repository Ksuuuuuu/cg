using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KG2
{
     
    public partial class FormMain : Form
    {
        private Color brush = Color.BlueViolet;

        public FormMain()
        {
            InitializeComponent();
        }

        private void bPaint_Click(object sender, EventArgs e)
        {
            Scene s = new Scene(pictureBoxView.Height, pictureBoxView.Width);
            s.brush = brush;
            s.addConus(Double.Parse(textBoxBoxSize.Text), Double.Parse(boxH.Text));
            s.addCamera(new Camera(new To4ka(textBoxCamPos.Text), new To4ka(textBoxCamDir.Text).minus(new To4ka(textBoxCamPos.Text)), (double)udAngle.Value));
            s.lightPoint = new To4ka(textBoxLights.Text);
            s.Render();
            pictureBoxView.Image = s.pic;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            brush = colorDialog.Color;
            bPaint_Click(sender, e);
        }

        private void FormMain_Paint(object sender, PaintEventArgs e)
        {
            bPaint_Click(sender, e);
        }

        private void pictureBoxView_MouseMove(object sender, MouseEventArgs e)
        {
            //if (DateTime.Today.Millisecond % 100 == 0)
            //{
            //    textBoxCamPos.Text = (11 * Math.Cos(e.X * 2 * Math.PI / pictureBoxView.Width)).ToString("0.##") + " "
            //        + (11 * Math.Sin(e.X * 2 * Math.PI / pictureBoxView.Height)).ToString("0.##") + " 3";
            //    bPaint_Click(sender, e);
            //}
        }
    }
}
