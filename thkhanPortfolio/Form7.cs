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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string outputFinal = "";
            try
            {
                double val1 = Convert.ToDouble(textBox1.Text);
                int precision = Convert.ToInt32(comboBox1.Text);
                double output = 0;
                double output2 = 0;
                for (int i = 0; i < (Convert.ToString(val1).Length); i++)
                {
                    if (Convert.ToString(val1).Substring(i, 1) == ".")
                    {
                        try
                        {
                            output = Convert.ToDouble(Convert.ToString(val1).Substring(0, i));
                            output2 = Convert.ToDouble(Convert.ToString(val1).Substring(i + 1, precision));
                            outputFinal = Convert.ToString((output + "." + output2));
                            label4.Text = outputFinal;
                        }
                        catch { }
                    }
                }
            }
            catch { }
            if (outputFinal == "")
            {
                MessageBox.Show("Input error");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
