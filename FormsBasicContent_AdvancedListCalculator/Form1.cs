using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsBasicContent_AdvancedListCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == "+")
            {
                textBox4.Text = "+";
            }
            if (listBox1.SelectedItem == "-")
            {
                textBox4.Text = "-";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "+")
            {
                double operator1 = double.Parse(textBox1.Text);
                double operator2 = double.Parse(textBox2.Text);
                textBox3.Text = (operator1 + operator2).ToString();
            }

            if (textBox4.Text == "-")
            {
                double operator1 = double.Parse(textBox1.Text);
                double operator2 = double.Parse(textBox2.Text);
                textBox3.Text = (operator1 - operator2).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
        }
    }
}
