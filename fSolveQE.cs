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
    public partial class fSolveQE : Form
    {
        public fSolveQE()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double c = double.Parse(txtC.Text);
                double r = b * b - 4 * a * c;

                if (a == 0)
                {
                    if (b == 0)
                    {
                        if (c != 0)
                            txtR.Text = "Đây là phương trình bậc 1 và vô nghiệm. Vui lòng nhập đủ cả ba giá trị a, b, c để giải phương trình bậc 2.";
                        else if (c == 0)
                            txtR.Text = "Đây là phương trình bậc 1 và có vô số nghiệm. Vui lòng nhập đủ cả ba giá trị a, b,c để giải phương trình bậc 2.";
                    }
                    else //b!=0
                    {
                        double n = -c / b;
                        txtR.Text = "Đây là phương trình bậc 1 với nghiệm là " + n + ". Vui lòng nhập đủ cả ba giá trị a, b, c để giải phương trình bậc 2.";
                    }
                }
                else //a!=0
                {
                    if (r < 0)
                        txtR.Text = "Đây là phương trình bậc 2 và vô nghiệm.";
                    else if (r == 0)
                    {
                        double x = (double)(-b / (2 * a));
                        txtR.Text = "Đây là phương trình bậc 2 và có nghiệm kép là x1 = x2 = " + x + ".";
                    }
                    else
                    {
                        double x1 = (double)((-b - Math.Sqrt(r)) / (2 * a));
                        double x2 = (double)((-b + Math.Sqrt(r)) / (2 * a));
                        txtR.Text = "Đây là phương trình bậc 2 và có nghiệm x1 = " + x1 + ", x2 = " + x2 + ".";
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Giá trị nhập vào chưa chính xác, vui lòng kiểm tra lại.");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Giá trị nhập vào chưa chính xác, vui lòng kiểm tra lại.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}