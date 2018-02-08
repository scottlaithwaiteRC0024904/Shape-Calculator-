using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double r = double.Parse(textBox1.Text);
                label2.Text = (4.0 * Math.PI * r * r).ToString("N");
                label3.Text = (4.0 / 3.0 * Math.PI * r * r * r).ToString("N");
            }
            catch
            {
                label2.Text = "N/A";
                label3.Text = "N/A";
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            cone();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            cone();
        }

        void cone()
        {
            try
            {
                double r = double.Parse(textBox2.Text);
                double h = double.Parse(textBox3.Text);
                label5.Text = (Math.PI * r * r + Math.PI * r * Math.Sqrt(h * h + r * r)).ToString("N");
                label6.Text = (1.0 / 3.0 * Math.PI * r * r * h).ToString("N");
            }
            catch
            {
                label5.Text = "N/A";
                label6.Text = "N/A";
            }
        }
    }
}
