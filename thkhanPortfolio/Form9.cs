using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace thkhanPortfolio
{
    public partial class Form9 : Form
    {
        public int cnt1;
        public int cnt2;
        public int cnt3;
        public int cnt4;
        public int cnt5;
        public int cnt6;
        public int randval;
        
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random objRand = new Random();
            randval = objRand.Next(1, 7);
            label7.Text = randval.ToString();
            button1.Enabled = false;
            button2.Enabled = true;
            button2.Focus();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (randval == 1)
            {
                pictureBox7.Location = pictureBox1.Location;
                pictureBox7.BringToFront();
                cnt1++;
                label1.Text = cnt1.ToString();
            }
            else if (randval == 2)
            {
                pictureBox7.Location = pictureBox2.Location;
                pictureBox7.BringToFront();
                cnt2++;
                label2.Text = cnt2.ToString();
            }
            else if (randval == 3)
            {
                pictureBox7.Location = pictureBox3.Location;
                pictureBox7.BringToFront();
                cnt3++;
                label3.Text = cnt3.ToString();
            }
            else if (randval == 4)
            {
                pictureBox7.Location = pictureBox4.Location;
                pictureBox7.BringToFront();
                cnt4++;
                label4.Text = cnt4.ToString();
            }
            else if (randval == 5)
            {
                pictureBox7.Location = pictureBox5.Location;
                pictureBox7.BringToFront();
                cnt5++;
                label5.Text = cnt5.ToString();
            }
            else if (randval == 6)
            {
                pictureBox7.Location = pictureBox6.Location;
                pictureBox7.BringToFront();
                cnt6++;
                label6.Text = cnt6.ToString();
            }
            button1.Enabled = true;
            if ((cnt1 >= 1) && (cnt2 >= 1) && (cnt3 >= 1) && (cnt4 >= 1) && (cnt5 >= 1) && (cnt6 >= 1))
            {
                button1.Enabled = false;
                button2.Enabled = false;
                MessageBox.Show("Game over");
            }
        }
    }
}
