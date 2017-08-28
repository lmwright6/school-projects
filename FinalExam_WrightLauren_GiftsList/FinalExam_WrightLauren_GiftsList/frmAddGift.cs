using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExam_WrightLauren_GiftsList
{
    public partial class frmAddGift : Form
    {

        public double Total;
        double Target;
        public double orderTotal;

        public frmAddGift()
        {
            InitializeComponent();
        }

        public frmAddGift(double target, double total)
        {
            
            InitializeComponent();
            this.Target = target;
            this.Total = total;

            txtBoxBudget.Text = "" + this.Target;
            txtBoxTotal.Text = "0";
            txtBoxRemaining.Text = "" + (this.Target - this.Total);

        }

        private void frmAddGift_Load(object sender, EventArgs e)
        {

        }

        private void numUDQuantity_ValueChanged(object sender, EventArgs e)
        {
            double newTotal = (double)numUDQuantity.Value * Double.Parse(txtBoxPrice.Text);


            txtBoxTotal.Text = "" + newTotal;

            changeRemaining(newTotal);
            
        }

        private void changeRemaining(double newTotal)
        {
            //i am subtracting what the user has remaing from the new total of the gift
            double rem = Double.Parse(txtBoxRemaining.Text) - newTotal;

            txtBoxRemaining.Text = "" + rem;
            if(rem < 0)
            {
               txtBoxRemaining.ForeColor = Color.Red;
            }

            this.orderTotal = this.Total + newTotal;
            



        }

        private void txtBoxPrice_TextChanged(object sender, EventArgs e)
        {

            bool isValid = DoubleValidate(txtBoxPrice.Text);
            if (isValid == true)
            {
                double newTotal = (double)numUDQuantity.Value * Double.Parse(txtBoxPrice.Text);


                txtBoxTotal.Text = "" + newTotal;

                changeRemaining(newTotal);
            }
            else
            {
                MessageBox.Show("Invalid Input, please put a number");
                txtBoxPrice.Focus();
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(Double.Parse(txtBoxRemaining.Text) < 0)
            {
                MessageBox.Show("This order for $" + orderTotal + " exceeds your budget, do something about it");

            }
            else
            {
                if (txtBoxGiftName.Text != "" && txtBoxPrice.Text != "")
                {
                    this.DialogResult = DialogResult.OK;
                    Gifts newGift = new Gifts(txtBoxGiftName.Text, Double.Parse(txtBoxPrice.Text), (Int32)numUDQuantity.Value);
                    this.Tag = newGift;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid input, try agian");
                    txtBoxGiftName.Focus();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool DoubleValidate(string test)
        {
            bool isValid;
            double tryIt;
            isValid = Double.TryParse(test, out tryIt);

            return isValid;
        }
    }
}
