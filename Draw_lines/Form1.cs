using System;
using System.Drawing;
using System.Windows.Forms;

namespace Draw_lines
{
    public partial class Form1 : Form
    {
        public Point centre;

        public Form1()
        {
            InitializeComponent();
            
            foreach(Control control in Controls)
            {
                if(control.GetType() == typeof(PictureBox))
                {
                    PictureBox pb = (PictureBox)control;
                    pb.Image = Clear((PictureBox)control);
                    centre = new Point(pb.Width / 2, pb.Height / 2);
                }
            }
        }

        public Image Clear(PictureBox pb)
        {
            Bitmap image = new Bitmap(pb.Size.Width, pb.Size.Height);

            for (int i = 0; i < pb.Size.Width; i++)
            {
                image.SetPixel(i, pb.Size.Height/2, Color.Black);
            }

            for (int i = 0; i < pb.Size.Height; i++)
            {
                image.SetPixel(pb.Size.Width / 2, i, Color.Black);
            }

            return image;
        }

        private void DrawVertically(PictureBox pb, int x, int y1, int y2, Color c)
        {
            Bitmap image = (Bitmap)pb.Image;

            int i = Math.Max(y1, y2);

            while(i >= Math.Min(y1,y2))
            {
                image.SetPixel(x + centre.X, -i + centre.Y, c);
                i--;
            }

            pb.Image = image;
        }

        //Algorytm przyrostowy
        private void IncrementalAlgorithm(PictureBox pb, Point p0, Point pk)
        {
            Bitmap image = (Bitmap)pb.Image;

            if (p0.X == pk.X)
            {
                DrawVertically(pb, p0.X, p0.Y, pk.Y, Color.Red);
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

                for (int a = 0; a < Math.Abs(dx*m); a++)
                {
                    image.SetPixel((int)Math.Round((xi)) + centre.X, -yi + centre.Y, Color.Red);

                    if(m < 0) xi -= 1 / m;
                    if (m > 0) xi += 1 / m;

                    if (p0.Y < pk.Y) yi += 1;
                    if (p0.Y > pk.Y) yi -= 1;
                }
            }

            pb.Image = image;
        }

        //Algorytm Bersenhama
        private void BresenhamAlgorithm(PictureBox pb, Point p0, Point pk)
        {
            Bitmap image = (Bitmap)pb.Image;

            if (p0.X == pk.X)
            {
                DrawVertically(pb, p0.X, p0.Y, pk.Y, Color.DarkKhaki);
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
                int delta_a = 2*(dy - dx);
                int delta_b = 2 * dy;

                int s = delta_b - dx;

                image.SetPixel(p0.X + centre.X, -p0.Y + centre.Y, Color.DarkKhaki);

                while(xi < pk.X)
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

        private void Clear1_btn_Click(object sender, EventArgs e)
        {
            pictureBoxIncremental.Image = Clear(pictureBoxIncremental);
        }

        private void Clear2_btn_Click(object sender, EventArgs e)
        {
            pictureBoxBersenham.Image = Clear(pictureBoxBersenham);
        }

        private void Draw1_btn_Click(object sender, EventArgs e)
        {
            Point startPoint = new Point((int)xPoint1Start.Value, (int)yPoint1Start.Value);
            Point endPoint = new Point((int)xPoint1End.Value, (int)yPoint1End.Value);

            IncrementalAlgorithm(pictureBoxIncremental, startPoint, endPoint);
        }

        private void Draw2_btn_Click(object sender, EventArgs e)
        {
            Point startPoint = new Point((int)xPoint2Start.Value, (int)yPoint2Start.Value);
            Point endPoint = new Point((int)xPoint2End.Value, (int)yPoint2End.Value);

            BresenhamAlgorithm(pictureBoxBersenham, startPoint, endPoint);
        }
    }
}
