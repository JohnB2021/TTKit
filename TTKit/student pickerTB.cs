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
    public partial class student_pickerTB : Form
    {
        public student_pickerTB()
        {
            InitializeComponent();
        }

        private const string V = "the student to be picked is ";
        private bool mouseDown;
        private Point lastLocation;





        private void timerTB_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void timerTB_MouseMove(object sender, MouseEventArgs e)     
        //qwertyisbest
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainTB = new Form1();
            mainTB.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (listBox1.Items.Count > 0)
            {
                int studentNum = rnd.Next(0, listBox1.Items.Count);
                textBox2.Text = V + listBox1.Items[studentNum].ToString();

                listBox1.Items.RemoveAt(studentNum);
            }
            else 
            {
                MessageBox.Show("Please add student!");            
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("You can not add a student without a name.");
            }
            else
            {
                listBox1.Items.Add(textBox1.Text);
            }
    
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void student_pickerTB_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Hide();
            button6.Show();
            label3.Hide();
            label4.Hide();
            label5.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Hide();
            button4.Show();
            label3.Show();
            label4.Show();
            label5.Show();
        }
    }

}
