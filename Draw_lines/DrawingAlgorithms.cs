using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw_lines
{
    public static class DrawingAlgorithms
    {
        public static void IncrementalAlgorithm(PictureBox pb, Point p0, Point pk)
        {
            Bitmap image = (Bitmap)pb.Image;
            var centre = new Point(pb.Width / 2, pb.Height / 2);

            if (p0.X == pk.X)
            {
                HorizontalVerticalLine.DrawVertically(pb, p0.X, p0.Y, pk.Y, Color.Red);
                return;
            }

            if (p0.X > pk.X)
            {
                Point auxiliary = p0;
                p0 = pk;
                pk = auxiliary;
            }

            double dy = pk.Y - p0.Y;
            double dx = pk.X - p0.X;

            double m = dy / dx;

            if (Math.Abs(m) <= 1)
            {
                int xi = p0.X;
                double yi = p0.Y;

                for (int a = 0; a < Math.Abs(dx); a++)
                {
                    image.SetPixel(xi + centre.X, -(int)Math.Round(yi) + centre.Y, Color.Red);
                    xi += 1;
                    yi += m;
                }
            }

            else
            {
                double xi = p0.X;
                int yi = p0.Y;

                for (int a = 0; a < Math.Abs(dx * m); a++)
                {
                    image.SetPixel((int)Math.Round((xi)) + centre.X, -yi + centre.Y, Color.Red);

                    if (m < 0) xi -= 1 / m;
                    if (m > 0) xi += 1 / m;

                    if (p0.Y < pk.Y) yi += 1;
                    if (p0.Y > pk.Y) yi -= 1;
                }
            }

            pb.Image = image;
        }

        public static void BresenhamAlgorithm(PictureBox pb, Point p0, Point pk)
        {
            Bitmap image = (Bitmap)pb.Image;
            var centre = new Point(pb.Width / 2, pb.Height / 2);

            if (p0.X == pk.X)
            {
                HorizontalVerticalLine.DrawVertically(pb, p0.X, p0.Y, pk.Y, Color.DarkKhaki);
                return;
            }

            if (p0.X > pk.X)
            {
                Point auxiliary = p0;
                p0 = pk;
                pk = auxiliary;
            }

            int xi = p0.X;
            int yi = p0.Y;

            int dy = pk.Y - p0.Y;
            int dx = pk.X - p0.X;

            int inc_y;

            if (p0.Y < pk.Y)
            {
                inc_y = 1;
                dy = pk.Y - p0.Y;
            }
            else
            {
                inc_y = -1;
                dy = p0.Y - pk.Y;
            }

            if (dx > dy)
            {
                int delta_a = 2 * (dy - dx);
                int delta_b = 2 * dy;

                int s = delta_b - dx;

                image.SetPixel(p0.X + centre.X, -p0.Y + centre.Y, Color.DarkKhaki);

                while (xi < pk.X)
                {
                    if (s >= 0)
                    {
                        s += delta_a;
                        xi += 1;
                        yi += inc_y;
                    }
                    else
                    {
                        s += delta_b;
                        xi += 1;
                    }

                    image.SetPixel(xi + centre.X, -yi + centre.Y, Color.DarkKhaki);
                }
            }

            else
            {
                int delta_a = 2 * (dx - dy);
                int delta_b = 2 * dx;

                int s = delta_b - dy;

                image.SetPixel(p0.X + centre.X, -p0.Y + centre.Y, Color.DarkKhaki);

                while (xi < pk.X)
                {
                    if (s >= 0)
                    {
                        s += delta_a;
                        xi += 1;
                        yi += inc_y;
                    }
                    else
                    {
                        s += delta_b;
                        yi += inc_y;
                    }

                    image.SetPixel(xi + centre.X, -yi + centre.Y, Color.DarkKhaki);
                }
            }

            pb.Image = image;
        }
    }
}
