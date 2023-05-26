using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;
using Tao.FreeGlut;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _3_lab
{
    public partial class Form1 : Form
    {

        private double height = 2;
        private double radius = 2;
        private int count_g = 3;
        private float transparency = 0.8f;
        private int lightCount = 0;
        public Form1()
        {
            InitializeComponent();
            AnT.InitializeContexts();
        }

        private void lightB_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = Grid.Rows[0];

                if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null && row.Cells[3].Value != null)
                {
                    int lightIndex = Gl.GL_LIGHT0 + lightCount;
                    Gl.glEnable(lightIndex);

                    float[] position =
                    {
                                (float)Convert.ToDecimal(row.Cells[0].Value),
                                (float)Convert.ToDecimal(row.Cells[1].Value),
                                (float)Convert.ToDecimal(row.Cells[2].Value),
                                1.0f
                            };
                    Gl.glLightfv(lightIndex, Gl.GL_POSITION, position);

                    float[] color =
                    {
                                ((Color)row.Cells[3].Value).R / 255.0f,
                                ((Color)row.Cells[3].Value).G / 255.0f,
                                ((Color)row.Cells[3].Value).B / 255.0f,
                                1.0f
                            };
                    Gl.glLightfv(lightIndex, Gl.GL_DIFFUSE, color);

                    lightCount++;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка входных данных!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);

            Gl.glClearColor(0, 0, 0, 1);

            Gl.glViewport(0, 0, AnT.Width, AnT.Height);

            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            const double W = 7;
            double H = W * AnT.Height / AnT.Width;
            Gl.glOrtho(-W, W, -H, H, -200, 200);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_COLOR_MATERIAL);
            Gl.glEnable(Gl.GL_LIGHTING);
        }

        private void Render(double x, double y)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glColor4f(3,3,3, transparency); //цвет

            Gl.glPushMatrix();
            Gl.glTranslated(0, 0, -20);
            Gl.glRotated((x - AnT.Height) * 180 / AnT.Height, 0, 1, 0);
            Gl.glRotated((y - AnT.Width) * 180 / AnT.Width, 1, 0, 0);

            Gl.glPushMatrix();
            Gl.glScaled(1, 1, 1); //масштаб
            Glut.glutSolidCone(radius, height, count_g, 1);
            Gl.glPopMatrix();

            Gl.glPopMatrix();

            Gl.glFlush();
            AnT.Invalidate();
        }

        private void HBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                height = Convert.ToDouble(HBox.Text);
            }
            catch (Exception)
            {
                height = 2;
            }
        }

        private void RBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                radius = Convert.ToDouble(RBox.Text);
            }
            catch (Exception)
            {
                radius = 2;
            }
        }

        private void CBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                count_g = Convert.ToInt32(CBox.Text);
            }
            catch (Exception)
            {
                count_g = 3;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            transparency = trackBar1.Value / 10f;
        }

        private void AnT_MouseMove(object sender, MouseEventArgs e)
        {
            Render(e.X, e.Y);
        }

        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (DialogResult.OK == colorDialog1.ShowDialog())
                {
                    Grid.Rows[e.RowIndex].Cells[3].Value = colorDialog1.Color;
                }
            }
        }
    }
}
