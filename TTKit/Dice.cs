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
    public partial class Dice : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private int Ds = 6;
        float waitTime = 3f;





        private void timerTB_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        
        private void timerTB_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();              
            }
        }                       

        private void timerTB_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        public Dice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainTB = new Form1();
            mainTB.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int Dice = rnd.Next(1, Ds + 1);
            textBox1.Text = Dice.ToString();
            label1.Hide();
            
        }

        private void Dice_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ds = 6;
            label1.Text = "Changed Dice 🗸 (D6)";
            label1.ForeColor = Color.FromArgb(192, 255, 192);
            label1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ds = 8;
            label1.Text = "Changed Dice 🗸 (D8)";
            label1.ForeColor = Color.FromArgb(255, 224, 192);
            label1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ds = 12;
            label1.Text = "Changed Dice 🗸 (D12)";
            label1.ForeColor = Color.FromArgb(255, 192, 192);
            label1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
