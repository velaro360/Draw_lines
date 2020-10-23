using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw_lines
{
    public static class HorizontalVerticalLine
    {
        public static void DrawVertically(PictureBox pb, int x, int y1, int y2, Color c)
        {
            Bitmap image = (Bitmap)pb.Image;
            Point centre = new Point(pb.Width / 2, pb.Height / 2);

            int i = Math.Max(y1, y2);

            while (i >= Math.Min(y1, y2))
            {
                image.SetPixel(x + centre.X, -i + centre.Y, c);
                i--;
            }

            pb.Image = image;
        }
    }
}
