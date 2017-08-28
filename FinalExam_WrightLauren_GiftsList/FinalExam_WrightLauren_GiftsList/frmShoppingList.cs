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
    public partial class frmShoppingList : Form
    {

        People p = new People();

        public frmShoppingList()
        {
            InitializeComponent();
        }

        public frmShoppingList(People p)
        {
            InitializeComponent();
            this.p = p;
        }


        private void frmShoppingList_Load(object sender, EventArgs e)
        {
            txtBoxShoppingList.Text = "**************************\r\n" + p.GetDisplay() + "\r\n**************************\r\nGifts\r\n**************************\r\n";
            for(int x = 0; x < p.giftList.Count; x++)
            {
                txtBoxShoppingList.AppendText(p.giftList[x].GetDisplay());
            }

            txtBoxShoppingList.AppendText("\r\n**************************");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
