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
    public partial class timerTB : Form
    {
        float countDown = 0;
        float timer = 0;
        int Countdown = 0;
        
        
        public timerTB()
        {
            InitializeComponent();
        }
        private bool mouseDown;
        private Point lastLocation;






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
        private void backBT_Click(object sender, EventArgs e)
        {
            Form1 mainTB = new Form1();
            mainTB.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countDown -= timer1.Interval * 0.001f;
            textBox1.Text = countDown.ToString("0.00");
            if (countDown < 10)
            {
                textBox1.BackColor = Color.Orange;
            }
            if (countDown < 0)
            {
                timer1.Enabled = false;
                timer = 0;
            }
            if (countDown > 10)
            {
                textBox1.BackColor = Color.White;
            }
            if (countDown < 5)
            {
                textBox1.BackColor = Color.Red;
            }
            Refresh();
            if (countDown > 0)
            {
                progressBar1.Minimum = 0;
                progressBar1.Maximum = Countdown;
                progressBar1.Value = (int)countDown;
            }
            if (countDown < 0)
            {
                countDown = 0;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (float.TryParse(textBox1.Text, out countDown))
            {
                timer1.Enabled = true;
                countDown = float.Parse(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Error (try pressing reset)");
            }
            if (countDown > 0)
            {
                progressBar1.Minimum = 0;
                progressBar1.Maximum = Countdown;
                progressBar1.Value = (int)countDown;
            }
           
            
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            timer = 0;
            textBox1.Text = timer.ToString();
            timer1.Enabled = false;
            textBox1.BackColor = Color.White;
            countDown = 0;
            Countdown = 0;
            progressBar1.Value = 0;
        }

        private void timerTB_Load(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {

            countDown = countDown + 60f;
            Countdown = Countdown + 60;
            textBox1.BackColor = Color.White;
            textBox1.Text = countDown.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            countDown = countDown + 180f;
            Countdown = Countdown + 180;
            textBox1.BackColor = Color.White;
            textBox1.Text = countDown.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            countDown = countDown + 300f;
            Countdown = Countdown + 300;
            textBox1.BackColor = Color.White;
            textBox1.Text = countDown.ToString();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            countDown = countDown + 600f;
            Countdown = Countdown + 600;
            textBox1.BackColor = Color.White;
            textBox1.Text = countDown.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            countDown = countDown + 900f;
            Countdown = Countdown + 900;
            textBox1.BackColor = Color.White;
            textBox1.Text = countDown.ToString();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            if (countDown > 0) 
            {
                progressBar1.Minimum = 0;
                progressBar1.Maximum = Countdown;
                progressBar1.Value = (int)countDown;
            }
            


        }

        private void button9_Click(object sender, EventArgs e)
        {
            countDown = countDown + 10f;
            Countdown = Countdown + 10;
            textBox1.BackColor = Color.White;
            textBox1.Text = countDown.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label5.Show();
            label6.Show();
            button11.Show();
            button10.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label5.Hide();
            label6.Hide();
            button10.Show();
            button11.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
