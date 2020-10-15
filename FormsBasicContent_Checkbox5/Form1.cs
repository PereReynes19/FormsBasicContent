using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsBasicContent_Checkbox5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " Dog";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " Cat";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " Mouse";
        }
    }
}
