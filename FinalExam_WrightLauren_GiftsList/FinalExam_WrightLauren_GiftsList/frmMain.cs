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
    public partial class frmMain : Form
    {
        
        //creating my list of people
        List<People> peopleList = new List<People>();
        private int peopleIndex;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnDataFill_Click(object sender, EventArgs e)
        {
            peopleList.Add(new People("Santa", "Dad", 350.0));
            peopleList.Add(new People("Mrs. Clause", "Mom", 360.0));
            peopleList.Add(new People("Rudolph", "Best Pal", 370.0));

            peopleList[0].giftList.Add(new Gifts("Candles", 1.99, 3));
            peopleList[0].giftList.Add(new Gifts("Perfume", 18.99, 1));
            peopleList[0].giftList.Add(new Gifts("Watch", 250.99, 1));

            peopleList[1].giftList.Add(new Gifts("Wax", 1.99, 3));
            peopleList[1].giftList.Add(new Gifts("Scarf", 18.99, 1));
            peopleList[1].giftList.Add(new Gifts("Chocolate", 250.99, 1));

            peopleList[2].giftList.Add(new Gifts("Shirt", 1.99, 3));
            peopleList[2].giftList.Add(new Gifts("Shoes", 18.99, 1));
            peopleList[2].giftList.Add(new Gifts("Pants", 250.99, 1));

            BindPeopleGrid();
            BindGiftsGrid(0);



        }

        public void BindPeopleGrid()
        {
            dgvPeople.DataSource = typeof(People);
            dgvPeople.DataSource = peopleList;

        }

        public void BindGiftsGrid(int x)
        {

            dgvGifts.DataSource = typeof(Gifts);
            dgvGifts.DataSource = peopleList[x].giftList;

        }

        private void dgvPeople_SelectionChanged(object sender, EventArgs e)
        {

            int index = dgvPeople.CurrentCell.RowIndex;
            BindGiftsGrid(index);

            txtBoxPersonName.Text = "" + peopleList[index].Name;
            txtBoxPersonRel.Text = "" + peopleList[index].Relationhsip;
            txtBoxPersonBudget.Text = "" + peopleList[index].Budget;

            peopleIndex = index;

            txtBoxTarget.Text = "" + peopleList[index].Budget;
            txtBoxTotal.Text = "" + sumGifts(peopleList[index]);
            txtBoxRemaining.Text = "" + (peopleList[index].Budget - sumGifts(peopleList[index]));


        }

        private void btnPersonAdd_Click(object sender, EventArgs e)
        {
            //create new form
            frmAddPerson adPersonForm = new frmAddPerson();

            


            if (adPersonForm.ShowDialog() == DialogResult.OK)
            {
                peopleList.Add((People)adPersonForm.Tag);
                BindPeopleGrid();
            }

            
        }

        private void btnPersonRemove_Click(object sender, EventArgs e)
        {
            peopleList.Remove(peopleList[dgvPeople.CurrentCell.RowIndex]);
            BindPeopleGrid();
            BindGiftsGrid(0);
        }

        private void btnPersonUpdate_Click(object sender, EventArgs e)
        {
            double pastBudget = peopleList[dgvPeople.CurrentCell.RowIndex].Budget;

            bool isValid = DoubleValidate(txtBoxPersonBudget.Text);

            if (isValid == true)
            {
                double newBudget = Double.Parse(txtBoxPersonBudget.Text);

                if (pastBudget > newBudget)
                {
                    double sum = sumGifts(peopleList[dgvPeople.CurrentCell.RowIndex]);
                    if (sum <= newBudget)
                    {
                        MessageBox.Show("The Budget for " + peopleList[dgvPeople.CurrentCell.RowIndex].Name + " was decreased from $" + pastBudget + " to $" + newBudget);
                        peopleList[dgvPeople.CurrentCell.RowIndex].Budget = Double.Parse(txtBoxPersonBudget.Text);
                    }
                    else
                    {
                        MessageBox.Show("To have a new budget of $" + newBudget + " you must remove gifts from your list");
                    }
                }
                else
                {
                    MessageBox.Show("The Budget for " + peopleList[dgvPeople.CurrentCell.RowIndex].Name + " was raised from $" + pastBudget + " to $" + newBudget);
                    peopleList[dgvPeople.CurrentCell.RowIndex].Budget = Double.Parse(txtBoxPersonBudget.Text);
                }


                BindPeopleGrid();
            }
            else
            {
                MessageBox.Show("Invalid Input, please put a number");
                txtBoxPersonBudget.Focus();
            }
        }

        private void dgvGifts_SelectionChanged(object sender, EventArgs e)
        {

            int index = dgvGifts.CurrentCell.RowIndex;
            //BindGifts(index);

            txtBoxGiftName.Text = "" + peopleList[peopleIndex].giftList[index].Name;
            txtBoxPrice.Text = "" + peopleList[peopleIndex].giftList[index].Price;
            txtBoxQuantity.Text = "" + peopleList[peopleIndex].giftList[index].Quantity;

        }

        private double sumGifts(People p)
        {
            double sum = 0;
          
            for(int x = 0; x < p.giftList.Count; x++)
            {
                sum += p.giftList[x].TotalPrice;
            }
            return sum;
        }

        private void btnGiftAdd_Click(object sender, EventArgs e)
        {
            frmAddGift fAdGift = new frmAddGift(Double.Parse(txtBoxTarget.Text), Double.Parse(txtBoxTotal.Text));

            if (fAdGift.ShowDialog() == DialogResult.OK)
            {
                peopleList[peopleIndex].giftList.Add((Gifts)fAdGift.Tag);
                BindPeopleGrid();
                BindGiftsGrid(0);

                double totalTemp = Double.Parse(txtBoxTotal.Text);
                txtBoxTotal.Text = "" + sumGifts(peopleList[peopleIndex]);
                txtBoxRemaining.Text = "" + (peopleList[peopleIndex].Budget - sumGifts(peopleList[peopleIndex]));

            }

        }

        private void btnGiftPrint_Click(object sender, EventArgs e)
        {
            frmShoppingList frmList = new frmShoppingList(peopleList[dgvPeople.CurrentCell.RowIndex]);
            if (frmList.ShowDialog() == DialogResult.OK)
            {


                //nothing happens

            }
        }

        public bool DoubleValidate(string test)
        {
            bool isValid;
            double tryIt;
            isValid = Double.TryParse(test, out tryIt);

            return isValid;
        }

        private void btnGiftRemove_Click(object sender, EventArgs e)
        {
            peopleList[peopleIndex].giftList.Remove(peopleList[dgvPeople.CurrentCell.RowIndex].giftList[dgvGifts.CurrentCell.RowIndex]);
            BindPeopleGrid();
            BindGiftsGrid(0);
        }
    }
}
