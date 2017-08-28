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
    public partial class frmPokemon : Form
    {
        public frmPokemon()
        {
            InitializeComponent();

            TypeComboBox2.SelectedIndex = 1;
            WeightComboBox.SelectedIndex = 1;
            HeightComboBox.SelectedIndex = 1;
             

            
        }

        private void CancelBtn2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void SaveBtn2_Click(object sender, EventArgs e)
        {

            Pokemon pokeObject = new Pokemon();

            bool isValid = Pokemon.Validate(NameTxtBox2.Text, HPTxtBox2.Text, TypeComboBox2.SelectedText, WeightTxtBox2.Text, HeightTxtBox2.Text);
            if (isValid == true)
            {
                pokeObject = setPokeArray();

                pokeObject = conversions(pokeObject);

                this.Tag = pokeObject;

                // ClearControls();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private Pokemon conversions(Pokemon pokeObject)
        {

            if(HeightComboBox.SelectedText == "m")
            {
                pokeObject.Height = pokeObject.Height * 39.3701;

            }

            if(WeightComboBox.SelectedText == "kg")
            {
                pokeObject.Weight = pokeObject.Weight * 35.274;
            }
            return pokeObject;
        }

       

        private Pokemon setPokeArray()
        {
            //declare an instance of pokemon
            Pokemon pokeObject = new Pokemon();

            pokeObject.Name = NameTxtBox2.Text;
            pokeObject.Type = TypeComboBox2.Text;
            pokeObject.HP = Int32.Parse(HPTxtBox2.Text);
            pokeObject.Weight = Double.Parse(WeightTxtBox2.Text);
            pokeObject.Height = Double.Parse(HeightTxtBox2.Text);

            return pokeObject;
            
        }
    }
}
