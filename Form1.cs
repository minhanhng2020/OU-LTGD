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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //}

            //private void label1_Click(object sender, EventArgs e)
            //{

            //}
            //}

            //    private void button1_Click(object sender, EventArgs e)
            //    {

            //    }
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            try
            {
                int r = int.Parse(txtA.Text);
                //if (r)
                //{
                    
                //}
                //else
                //    txtResult.Text = "Nhập sai giá trị.";
            }
            catch (FormatException)
            {
                txtResult.Text = "Chưa nhập giá trị.";
            }
        }
    }
}
