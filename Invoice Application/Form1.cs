using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice_Application
{
    public partial class frmInvoice : Form
    {
        double subTotal, discountPercent, discountAmount, total;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                subTotal = Convert.ToDouble(txtPriceSub.Text);
                if (subTotal >= 1 && subTotal <= 99)
                {
                    subTotal = Convert.ToDouble(txtPriceSub.Text);
                    discountPercent = 0.01;
                    discountAmount = subTotal * discountPercent;
                    total = subTotal - discountAmount;
                    lblDisAmountResult.Text = "$ " + discountAmount.ToString("#.##");
                    lblDisPercentResult.Text = "1.00%";
                    lblTotalResult.Text = "$ " + total.ToString("#.##");
                }
                else if (subTotal >= 100 && subTotal <= 199)
                {
                    subTotal = Convert.ToDouble(txtPriceSub.Text);
                    discountPercent = 0.02;
                    discountAmount = subTotal * discountPercent;
                    total = subTotal - discountAmount;
                    lblDisAmountResult.Text = "$ " + discountAmount.ToString("#.##");
                    lblDisPercentResult.Text = "2.00%";
                    lblTotalResult.Text = "$ " + total.ToString("#.##");
                }
                else if (subTotal >= 200 && subTotal <= 299)
                {
                    subTotal = Convert.ToDouble(txtPriceSub.Text);
                    discountPercent = 0.03;
                    discountAmount = subTotal * discountPercent;
                    total = subTotal - discountAmount;
                    lblDisAmountResult.Text = "$ " + discountAmount.ToString("#.##");
                    lblDisPercentResult.Text = "3.00%";
                    lblTotalResult.Text = "$ " + total.ToString("#.##");
                }
                else if (subTotal >= 300)
                {
                    subTotal = Convert.ToDouble(txtPriceSub.Text);
                    discountPercent = 0.04;
                    discountAmount = subTotal * discountPercent;
                    total = subTotal - discountAmount;
                    lblDisAmountResult.Text = "$ " + discountAmount.ToString("#.##");
                    lblDisPercentResult.Text = "4.00%";
                    lblTotalResult.Text = "$ " + total.ToString("#.##");
                }
                else
                {
                    MessageBox.Show("Please enter a number above ZERO!");
                }
            }
            catch
            {
                MessageBox.Show("Invalid data was entered.");
            }
        }


        private void txtPriceSub_TextChanged(object sender, EventArgs e)
        {
            lblDisAmountResult.Text = "";
            lblDisPercentResult.Text = "";
            lblTotalResult.Text = "";
        }

        public frmInvoice()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisAmountResult.Text = "";
            lblDisPercentResult.Text = "";
            lblTotalResult.Text = "";
            txtPriceSub.Text = "";
        }
    }
}
