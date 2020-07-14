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
    public partial class fCalculator2 : Form
    {
        public fCalculator2()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int a = checked(int.Parse(txt1.Text));
                int b = checked(int.Parse(txt2.Text));
                if (RBtnPlus.Checked)
                    txtResult.Text = String.Format("{0}", checked(a + b));
                else if (RBtnMinus.Checked)
                    txtResult.Text = String.Format("{0}", a - b);
                else if (RBtnMultiply.Checked)
                    txtResult.Text = String.Format("{0}", checked(a * b));
                else if(RBtnDividedBy.Checked)
                {
                    if (b == 0)
                        throw new DivideByZeroException("Số chia phải khác 0");
                    txtResult.Text = String.Format("{0:0.00}", (double)a / b);
                }
                else
                    txtResult.Text = String.Format("{0}", a % b);
            }
            catch(FormatException)
            {
                txtResult.Text = "Bạn phải nhập hai số";
            }
            catch (DivideByZeroException ex)
            {
                txtResult.Text = ex.Message;
            }
            catch (OverflowException)
            {
                txtResult.Text = "Không thể xử lý số quá lớn";
            } 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
