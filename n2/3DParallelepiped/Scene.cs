using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace KG2
{
    class Scene
    {
        public Color brush = Color.BlueViolet;
        public Bitmap pic;
        public int height, width;
        public Camera cam;
        double del; 
        public List<To4ka> verts;
        public List<Triangle> polys;
        public To4ka lightPoint;
        double[,] Zbuffer;

        public Scene(int aheight, int awidth)
        {
            height = aheight;
            width = awidth;
            pic = new Bitmap(width, height);
            verts = new List<To4ka>();
            polys = new List<Triangle>();
        }
        public void addConus(double radius, double _height)
        {
            int h = 10; // шаг по окружности, в градусах
            List<To4ka> krug = new List<To4ka>(); // Окружность при z=0
            for (int i = 0; i < 360; i += h)
            {
                double rad = i * Math.PI / 180;
                krug.Add(new To4ka(radius * Math.Cos(rad), radius * Math.Sin(rad), 0));
            }

          
            verts.Add(new To4ka(0, 0, _height)); // Верхняя точка

            for (int i = 0; i < krug.Count - 1; i++) polys.Add(new Triangle(krug[i], krug[i + 1], verts[0], brush)); // Поверхность от 
            polys.Add(new Triangle(krug[krug.Count - 1], krug[0], verts[0], brush));                        // верха до 1/4

           
            verts.AddRange(krug);
            
        }

        public void addCamera(Camera acam)
        {
            cam = acam;
            del = 1 / Math.Tan(cam.angle / 2); // отношение z к половине ширины
        }

        public Point convertToScreenPoint(To4ka v)
        {
            Point result = new Point();
            result.X = (int)Math.Round(v.Vcam.getX() / v.Vcam.getZ() * del * (double)width / 2 + (double)width / 2); //преобразовываем в экранные координаты
            result.Y = (int)Math.Round(v.Vcam.getY() / v.Vcam.getZ() * del * (double)width / 2 + (double)height / 2);
            return result;
        }

        // проверяет, находится ли точка в треугольнике или нет
        public bool CheckPoint(Point pnt, List<Point> pnts)
        {
            To4ka v0, v1, v2;
            v0 = new To4ka(pnt).minus(new To4ka(pnts[0]));
            v1 = new To4ka(pnts[1]).minus(new To4ka(pnts[0]));
            v2 = new To4ka(pnts[2]).minus(new To4ka(pnts[0]));
            if (Math.Abs(v2.findAngle(v1) - v2.findAngle(v0) - v1.findAngle(v0)) > 1e-3)
                return false;

            v0 = new To4ka(pnt).minus(new To4ka(pnts[1]));
            v1 = new To4ka(pnts[0]).minus(new To4ka(pnts[1]));
            v2 = new To4ka(pnts[2]).minus(new To4ka(pnts[1]));
            if (Math.Abs(v2.findAngle(v1) - v2.findAngle(v0) - v1.findAngle(v0)) > 1e-3)
                return false;

            return true;
        }

        // Находит точку на грани, которая смотрит в заданную точку на экране
        public To4ka findVertex(Point pnt, Triangle poly)
        {
            To4ka onScreen = new To4ka((pnt.X - (double)width / 2) / (del * (double)width / 2), (pnt.Y - (double)height / 2) / (del * (double)width / 2), 1);
            To4ka norm = poly.normalCam;
            double A = norm.X,
                B = norm.Y,
                C = norm.Z,
                D = -(A * poly.v0.Vcam.getX() + B * poly.v0.Vcam.getY() + C * poly.v0.Vcam.getZ());
            double t = -D / (A * onScreen.getX() + B * onScreen.getY() + C * onScreen.getZ());
            return onScreen.scale(t);
        }

        public Color colorWithLight(To4ka t, Triangle poly)
        {
            double R = 20, G = 20, B = 20;

            To4ka norm = poly.normalCam;
            To4ka ray = lightPoint.Vcam.minus(t); //от точки до источника освещения
            if (ray.findAngle(norm) < Math.PI / 2)
            {
                double cos = Math.Pow(Math.Cos(ray.findAngle(norm)), 0.5);
                R = cos * poly.color.R;
                G = cos * poly.color.G;
                B = cos * poly.color.B;
            }
            return Color.FromArgb(Math.Min((int)R, 255), Math.Min((int)G, 255), Math.Min((int)B, 255));
        }

        // рисует полигон на экране
        public void DrawPolygon(Triangle poly)
        {
            List<Point> pnts = new List<Point>();
            pnts.Add(convertToScreenPoint(poly.v0));
            pnts.Add(convertToScreenPoint(poly.v1));
            pnts.Add(convertToScreenPoint(poly.v2));

            int minX, minY, maxX, maxY;
            minX = maxX = pnts[0].X;
            minY = maxY = pnts[0].Y;
            foreach (Point pnt in pnts)
            {
                minX = Math.Min(minX, pnt.X);
                maxX = Math.Max(maxX, pnt.X);
                minY = Math.Min(minY, pnt.Y);
                maxY = Math.Max(maxY, pnt.Y);
            }
            minX = Math.Max(minX, 0);
            minY = Math.Max(minY, 0);
            maxX = Math.Min(maxX, width - 1);
            maxY = Math.Min(maxY, height - 1);
            for (int X = minX; X <= maxX; X++)
                for (int Y = minY; Y <= maxY; Y++)
                {
                    Point curp = new Point(X, Y);
                    if (CheckPoint(curp, pnts))
                    {
                        To4ka curV = findVertex(curp, poly);
                        if (curV.getZ() < Zbuffer[X, Y])
                        {
                            Zbuffer[X, Y] = curV.getZ();
                            pic.SetPixel(X, Y, colorWithLight(curV, poly));
                        }
                    }
                }
        }

        public void Render()
        {
            if (cam != null)
            {
                //вычисление проекционных координат
                foreach (To4ka vr in verts)
                    vr.rotateForCam(cam);
                lightPoint.rotateForCam(cam);
                Graphics gr = Graphics.FromImage(pic);
                gr.Clear(Color.White);
                Zbuffer = new double[width, height];
                for (int i = 0; i < width; i++)
                    for (int j = 0; j < height; j++)
                        Zbuffer[i, j] = 10000;  //устанавливаем линию горизонта

                foreach (Triangle pl in polys)
                    if (pl.v0.minus(cam.pos).findAngle(pl.normal) > Math.PI / 2)  //если плоскость смотрит в сторону камеры
                        if (pl.v0.Vcam.getZ() > 0.2 && pl.v1.Vcam.getZ() > 0.2 && pl.v2.Vcam.getZ() > 0.2) //и если она не лежит за ней
                            DrawPolygon(pl);
            }
        }
    }
}
