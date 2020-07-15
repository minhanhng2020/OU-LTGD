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

            //Xử Lý Ngoại Lệ Không Nhập Giá Trị Cho txtA/txtC:
            catch (FormatException)
            {
                MessageBox.Show("Giá trị nhập vào chưa đúng. Vui lòng kiểm tra lại.");
            }

            //Xử Lý Ngoại Lệ Nhập Sai Giá Trị ở txtA/txtC:
            //...
            //...

        }

        private void btnAct2_Click(object sender, EventArgs e)
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

            //Xử Lý Ngoại Lệ Không Nhập Giá Trị Cho txtA/txtC:
            catch (FormatException)
            {
                MessageBox.Show("Giá trị nhập vào chưa đúng. Vui lòng kiểm tra lại.");
            }
        }
    }
}
