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
    public partial class frmAddPerson : Form
    {
        public frmAddPerson()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isValid = DoubleValidate(txtBoxBudget.Text);
            if (txtBoxName.Text != "" && txtBoxRelationship.Text !="" && isValid == true)
            {
                People p = new People(txtBoxName.Text, txtBoxRelationship.Text, Double.Parse(txtBoxBudget.Text));
                Tag = p;
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Invalid Input, try again");
                txtBoxName.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void frmAddPerson_Load(object sender, EventArgs e)
        {

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
