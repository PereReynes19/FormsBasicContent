using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsBasicContent_ListOptions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Yellow")
            {
                textBox1.Text = "The chosen colour is: Yellow";
            }
            if (comboBox1.SelectedItem == "Green")
            {
                textBox1.Text = "The chosen colour is: Green";
            }
            if (comboBox1.SelectedItem == "Blue")
            {
                textBox1.Text = "The chosen colour is: Blue";
            }
            if (comboBox1.SelectedItem == "Red")
            {
                textBox1.Text = "The chosen colour is: Red";
            }
            if (comboBox1.SelectedItem == "Orange")
            {
                textBox1.Text = "The chosen colour is: Orange";
            }
           
        }
    }
}
