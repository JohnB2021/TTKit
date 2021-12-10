using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTKit
{
    public partial class painter : Form
    {
        int x = 100;
        int y = 100;
        int xv = 5;
        int yv = 5;
        public painter()
        {
            InitializeComponent();
        }

        private void backBT_Click(object sender, EventArgs e)
        {
            Form1 mainTB = new Form1();
            mainTB.Show();
            this.Hide();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen penBlack = new Pen(Color.Black, 2);
            SolidBrush brushRed = new SolidBrush(Color.OrangeRed);
            SolidBrush brushGreen = new SolidBrush(Color.FromArgb(128,255,128));

            e.Graphics.DrawLine(penBlack, 10, 10, 100, 100);
            e.Graphics.DrawLine(penBlack, 100, 100, 200, 10);

            e.Graphics.DrawRectangle(penBlack, new Rectangle(100, 100, 50, 50));
            e.Graphics.FillRectangle(brushRed, new Rectangle(100, 100, 50, 50));

            e.Graphics.DrawEllipse(penBlack, new Rectangle(x, y, 25, 25));
            e.Graphics.FillEllipse(brushGreen, new Rectangle(x, y, 25, 25));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x += xv;
            y += yv;
            if (x < 0 || x > pictureBox1.Width) { xv *= -1; }
            if (y < 0 || y > pictureBox1.Height) { yv *= -1; }
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
