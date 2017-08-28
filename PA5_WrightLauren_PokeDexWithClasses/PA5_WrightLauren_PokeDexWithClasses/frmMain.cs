using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA5_WrightLauren_PokeDexWithClasses
{
    public partial class frmMain : Form
    {
        List<Pokemon> pokeList = new List<Pokemon>() { };

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            frmPokemon addPokemon = new frmPokemon();
           
            // Show the settings form
            
            if (addPokemon.ShowDialog() == DialogResult.OK)
            {
                Pokemon poke = (Pokemon)addPokemon.Tag;
                pokeList.Add(poke);
                BindGrid();
            }

        }

        private void BindGrid()
        {
            PokeDexDgv.DataSource = typeof(Pokemon);
            PokeDexDgv.DataSource = pokeList;

            numPokemonLbl.Text = "PokeDex contains " + pokeList.Count() + " Pokemon";

        }

        

        private void NameBtn_Click(object sender, EventArgs e)
        {
            pokeList = pokeList.OrderBy(x => x.Name).ToList();
            NameRBtn.Select();
            BindGrid();
        }

        private void WeightBtn_Click(object sender, EventArgs e)
        {
            pokeList = pokeList.OrderBy(x => x.Weight).ToList();
            WeightRBtn.Select();
            BindGrid();
        }

        private void HPBtn_Click(object sender, EventArgs e)
        {
            pokeList = pokeList.OrderBy(x => x.HP).ToList();
            HPRBtn.Select();
            BindGrid();
        }

        private void HeightBtn_Click(object sender, EventArgs e)
        {
            pokeList = pokeList.OrderBy(x => x.Height).ToList();
            HeightRBtn.Select();
            BindGrid();
        }

        private void TypeBtn_Click(object sender, EventArgs e)
        {
            pokeList = pokeList.OrderBy(x => x.Type).ToList();
            TypeRBtn.Select();
            BindGrid();
        }

        private void DataFillBtn_Click(object sender, EventArgs e)
        {

            DataFillBtn.Enabled = false;
            pokeList.Add(new Pokemon("Dumbledore", 1010, "Ghost", 3, 4));
            pokeList.Add(new Pokemon("Hermoine", 76, "Normal", 50, 1.67));
            pokeList.Add(new Pokemon("Harry", 234, "Fighting", 5, 45));
            pokeList.Add(new Pokemon("Ron", 2, "Fairy", 98, 23));
            pokeList.Add(new Pokemon("Hagrid", 55, "Dragon", 200, 7));

            BindGrid();

        }

        private void PokeDexDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                NameTxtBox.Text = pokeList[e.RowIndex].Name;
                HPTxtBox.Text = "" + pokeList[e.RowIndex].HP;
                TypeTxtBox.Text = pokeList[e.RowIndex].Type;
                WeightTxtBox.Text = "" + pokeList[e.RowIndex].Weight;
                HeightTxtBox.Text = "" + pokeList[e.RowIndex].Height;
            }

        }
    }
}
