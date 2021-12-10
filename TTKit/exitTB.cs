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
    public partial class exitTB : Form
    {
        int x = 100;
        int y = 100;
        int xv = 5;
        int yv = 5;
        public exitTB()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void exitTB_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x += xv;
            y += yv;
            if (x < 0 || x > pictureBox1.Width) { xv *= -1; }
            if (y < 0 || y > pictureBox1.Height) { yv *= -1; }
            Refresh();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            Pen penBlack = new Pen(Color.Black, 2);
            SolidBrush brushRed = new SolidBrush(Color.OrangeRed);
            SolidBrush brushGreen = new SolidBrush(Color.FromArgb(128, 255, 128));

            e.Graphics.DrawEllipse(penBlack, new Rectangle(x, y, 0, 0));
            e.Graphics.FillEllipse(brushGreen, new Rectangle(x, y, 0, 0));
        }
    }
}
