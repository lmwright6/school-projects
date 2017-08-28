using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA4_Wright_Lauren
{
    public partial class frmMain : Form
    {
        private int rowSpot = 0;
        List <Pokemon> pokeList = new List<Pokemon>();
        
        private string sortType = "";
        

        public frmMain()
        {
            InitializeComponent();
        }

        
        private void AddBtn_Click(object sender, EventArgs e)
        {
            bool isValid = Pokemon.Validate(NameTxtBox.Text, HPTxtBox.Text, TypeTxtBox.Text,WeightTxtBox.Text, HeightTxtBox.Text);

            if(isValid == true)
            {
                if (rowSpot < 10)
                {
                    setPokeArray();
                }

                else
                {
                    MessageBox.Show("PokeDex is full, no more additions allowed");
                }
            }

            ClearControls();            
        }

        public void ClearControls()
        {
            NameTxtBox.Clear();
            HPTxtBox.Clear();
            TypeTxtBox.Clear();
            WeightTxtBox.Clear();
            HeightTxtBox.Clear();
        }


        private void setPokeArray()
        {
            //declare an instance of pokemon
            Pokemon pokeObject = new Pokemon();

            pokeObject.Name = NameTxtBox.Text;
            pokeObject.Type = TypeTxtBox.Text;
            pokeObject.HP = Int32.Parse(HPTxtBox.Text);
            pokeObject.Weight = Double.Parse(WeightTxtBox.Text);
            pokeObject.Height = Double.Parse(HeightTxtBox.Text);


            pokeList.Add(pokeObject);

            rowSpot++;

            
            NumPokemonTxtBox.Text = rowSpot.ToString();
        }

        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "POKEDEX \r\n" + "________________\r\n";
         
            txtDisplay.AppendText("\r\nSort Type: " + sortType);

            int x = 1;
            foreach (var value in pokeList)
            {
                txtDisplay.AppendText("\r\n\r\nPokemon # " + (x) + value.OutString());
                x++;
            }
        }



        private void NameBtn_Click(object sender, EventArgs e)
        {
            //Array.Sort(pokeArray, delegate(Pokemon x,Pokemon y) {return x.Name.CompareTo(y.Name); });

            pokeList = pokeList.OrderBy(x => x.Name).ToList();
            sortType = "Name"; 
        }

        private void HPBtn_Click(object sender, EventArgs e)
        {
            //Array.Sort(pokeArray, delegate(Pokemon x, Pokemon y) { return x.HP.CompareTo(y.HP); });
            pokeList = pokeList.OrderBy(x => x.HP).ToList();
            sortType = "HP";

        }

        private void TypeBtn_Click(object sender, EventArgs e)
        {
            //Array.Sort(pokeArray, delegate(Pokemon x, Pokemon y) { return x.Type.CompareTo(y.Type); });
            pokeList = pokeList.OrderBy(x => x.Type).ToList();
            sortType = "Type";

        }

        private void WeightBtn_Click(object sender, EventArgs e)
        {
            //Array.Sort(pokeArray, delegate(Pokemon x, Pokemon y) { return x.Weight.CompareTo(y.Weight); });
            pokeList = pokeList.OrderBy(x => x.Weight).ToList();
            sortType = "Weight";

        }

        private void HeightBtn_Click(object sender, EventArgs e)
        {
            //Array.Sort(pokeArray, delegate(Pokemon x, Pokemon y) { return x.Height.CompareTo(y.Height); });
            pokeList = pokeList.OrderBy(x => x.Height).ToList();
            sortType = "Height";
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
