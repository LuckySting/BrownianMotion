using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrownianMotion
{
    class Molecule
    {
        private double x;

        private double y;

        private double max_x;

        private double max_y;

        private int seed;

        private int radius = 3;

        public Molecule(int seed, double max_x = 440, double max_y = 320)
        {
            Random rnd = new Random(seed);
            this.x = rnd.NextDouble() * max_x;
            this.y = rnd.NextDouble() * max_y;
            this.max_x = max_x;
            this.max_y = max_y;
            this.seed = seed;
        }

        public void update(object drawBox)
        {
            var pen = new SolidBrush(Color.White);
            var graphics = ((PictureBox)drawBox).CreateGraphics();
            graphics.FillRectangle(pen, (float)(this.x - radius), (float)(this.y - radius),
                      (float)(radius + radius+2), (float)(radius + radius+2));

            Random rnd = new Random();
            double max_angle = 2 * Math.PI;
            double angle = rnd.NextDouble() * max_angle;
            int distance = rnd.Next(1, 2 * radius);
            this.x += Math.Sin(angle) * distance;
            this.y += Math.Cos(angle) * distance;
            if (this.x >= max_x)
            {
                this.x = max_x - 3;
            }
            if (this.y > max_y)
            {
                this.y = max_y - 3;
            }
            if (this.x <= 0)
            {
                this.x = 3;
            }
            if (this.y <= 0)
            {
                this.y = 3;
            }
            pen.Color = Color.Black;

            graphics.FillEllipse(pen, (float)(this.x - radius), (float)(this.y - radius),
                      (float)(radius + radius), (float)(radius + radius));
            pen.Dispose();
            graphics.Dispose();
        }
    }
}
