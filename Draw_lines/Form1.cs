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

            centre = new Point(pictureBoxBersenham.Width / 2, pictureBoxBersenham.Height / 2);

            pictureBoxIncremental.Image = Clear(pictureBoxIncremental);
            pictureBoxBersenham.Image = Clear(pictureBoxBersenham);
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

            DrawingAlgorithms.IncrementalAlgorithm(pictureBoxIncremental, startPoint, endPoint);
        }

        private void Draw2_btn_Click(object sender, EventArgs e)
        {
            Point startPoint = new Point((int)xPoint2Start.Value, (int)yPoint2Start.Value);
            Point endPoint = new Point((int)xPoint2End.Value, (int)yPoint2End.Value);

            DrawingAlgorithms.BresenhamAlgorithm(pictureBoxBersenham, startPoint, endPoint);
        }
    }
}
