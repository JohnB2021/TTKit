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
    public partial class Form1 : Form
    {
        public Form1()
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











        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timerBT_Click(object sender, EventArgs e)
        {
            timerTB timerTB = new timerTB();
            timerTB.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            exitTB exitTB = new exitTB();
            exitTB.Show();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dice Dice = new Dice();
            Dice.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            student_pickerTB student_pickerTB = new student_pickerTB();
            student_pickerTB.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            painter painter = new painter();
            painter.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            seating_generatorTB seating_generatorTB = new seating_generatorTB();
            seating_generatorTB.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Hide();
            button6.Show();
            label1.Hide();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            button11.Show();
            button6.Hide();
            label1.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int timemins = DateTime.Now.Minute;
            int timehour = DateTime.Now.Hour;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            stop_watchTB stop_WatchTB = new stop_watchTB();
            stop_WatchTB.Show();
            this.Hide();
        }
    }
}
