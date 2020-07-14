using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ASCIIConversion
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txt1.Text);
            double b = double.Parse(txt2.Text);

            txtResult.Text = String.Format("{0}", a + b);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txt1.Text);
            double b = double.Parse(txt2.Text);

            txtResult.Text = String.Format("{0}", a - b);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txt1.Text);
            double b = double.Parse(txt2.Text);

            txtResult.Text = String.Format("{0}", a * b);
        }

        private void btnDevidedBy_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txt1.Text);
            double b = double.Parse(txt2.Text);
            if (b!=0)
            {
                txtResult.Text = String.Format("{0:0.00}", a / b);                
            }
            else
            {
                txtResult.Text = "Số chia phải khác 0";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
