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
    public partial class seating_generatorTB : Form
    {
        int[] classList = new int[10];
        public seating_generatorTB()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            this.Hide();
            Form1.Show();




        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Random rnd = new Random();
            for(int i=0;i<10;i++)
            {
                classList[i] = i;
                //textBox1.AppendText(classList[i].ToString() + "/r/n");
            }
            for(int i=0;i<10;i++)
            {
                int rnum = rnd.Next(0, 10);
                int temp = classList[i];
                classList[i] = classList[rnum];
                classList[rnum] = temp;

            }
            for (int i = 0; i < 10; i++)
            {
                textBox1.AppendText(classList[i].ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
