using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonStatConverter
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            

        }


        /*
         * 
         * */
        public bool Validate()
        {

            string pokeWeightStr = WeightTxtBox.Text;
            string pokeHeightStr = HeightTxtBox.Text;
            double pokeWeight = 0;
            double pokeHeight = 0;
            bool isValid = true;
            string pokeName = NameTxtBox.Text;


            try
            {
                if (pokeName.Length >= 3)
                {

                    HeightTxtBox.Enabled = true;
                    WeightTxtBox.Enabled = true;
                }
                else
                {
                    isValid = false;
                    throw new Exception("Pokemon name is not long enough (must be atleast three characters)");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Pokemon name is not long enough (must be atleast three characters)");
            }
                
                
            


            if (isValid == true)
            {
                //wiehgt isnt a number
                try
                {

                    pokeWeight = Double.Parse(pokeWeightStr);

                }

                catch (FormatException)
                {
                    MessageBox.Show("Weight must be a numerical value");
                    WeightTxtBox.Clear();
                    WeightTxtBox.Focus();
                    isValid = false;
                }
            }




            if (isValid == true)
            {

                //height isnt a number
                try
                {
                    pokeHeight = Double.Parse(pokeHeightStr);

                }
                catch (FormatException)
                {
                    MessageBox.Show("Height must be a numerical value");
                    HeightTxtBox.Clear();
                    HeightTxtBox.Focus();
                    isValid = false;
                }
                finally
                {

                };
            }



            bool keepGoing = true;

            if (isValid == true)
            {


                
                    //negethive height
                    if (pokeHeight > 1000 || pokeHeight < .001)
                    {
                        MessageBox.Show("Height must be between 1000 m and .001 m");
                        HeightTxtBox.Clear();

                        HeightTxtBox.Focus();
                        isValid = false;

                    }


                    //negative weight
                    else if (pokeWeight > 9000 || pokeWeight < .01 && isValid == true)
                    {
                        MessageBox.Show("Weight must be between 9000 kg and .01 kg");
                        WeightTxtBox.Clear();

                        WeightTxtBox.Focus();
                        isValid = false;
                    }
                    
                    
                
            }

            return isValid;
        

            
        }//Validate method


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Convert_Click(object sender, EventArgs e)
        {
            bool isValid = Validate();
            if (isValid == true)
            {
                ConvertWeight();
                ConvertHeight();
                
            }
            WeightClassLookUp(isValid);
            HeightClassLookUp(isValid);
            

        }



        private void HeightClassLookUp(bool isValid)
        {
            if (isValid == true)
            {
                double convHeight = Double.Parse(HeightTxtBox.Text);

                //identify height classification
                if (convHeight < 30)
                {
                    HeightClassTxtBox.Text = "Short";

                }//end if

                else if (convHeight >= 30 && convHeight <= 49)
                {
                    HeightClassTxtBox.Text = "Normal";
                }//ebd else if

                else if (convHeight >= 50)
                {
                    HeightClassTxtBox.Text = "Tall";
                }//end else if
            }
            else
            {
                HeightClassTxtBox.Text = "Unknown";
            }

        }


        private void ConvertWeight()
        {
            const double WEIGHT_CONV = 35.274;
            string weightStr = WeightTxtBox.Text;
            double weight = Double.Parse(weightStr);

            double convWeight = WEIGHT_CONV * weight;

            convWeight = Math.Round(convWeight,1);
            ConvWeightTxtBox.Text = convWeight.ToString();
        }



        private void ConvertHeight()
        {
            const double HEIGHT_CONV = 39.3701;
            string heightStr = HeightTxtBox.Text;
            double height = Double.Parse(heightStr);

            double convHeight = HEIGHT_CONV * height;

            convHeight = Math.Round(convHeight, 2);


            ConvHeightTxtBox.Text = convHeight.ToString();
        }



        private void WeightClassLookUp(bool isValid)
        {

            if (isValid == true)
            {
                double convWeight = Double.Parse(WeightTxtBox.Text);


                //identify weight classification
                if (convWeight < 100)
                {
                    WeightClassTxtBox.Text = "Extra Small";

                }//end if

                else if (convWeight >= 100 && convWeight < 500)
                {
                    WeightClassTxtBox.Text = "Normal";
                }//ebd else if

                else if (convWeight >= 500)
                {
                    WeightClassTxtBox.Text = "Extra Large";
                }//end else if
            }

            else
            {
                WeightClassTxtBox.Text = "Unknown";
            }

        
        }

        private void NameTxtBox_TextChanged(object sender, EventArgs e)
        {
            ClearControls();
            string name = NameTxtBox.Text;
            
            //validate input
            if(name.Length >= 3)
            {
                HeightTxtBox.Enabled = true;
                WeightTxtBox.Enabled = true;
                ConvertBtn.Enabled = true;

              //  ClearControls();
            }
            else
            {
                HeightTxtBox.Enabled = false;
                WeightTxtBox.Enabled = false;
                ConvertBtn.Enabled = false;
               

            }
           
            //bool isValid = Validate();


        }





        private void ClearControls()
        {
            //clear all text boxes
            
            WeightTxtBox.Text = String.Empty;
            HeightTxtBox.Text = String.Empty;
            ConvWeightTxtBox.Text = String.Empty;
            ConvHeightTxtBox.Text = String.Empty;
            WeightClassTxtBox.Text = String.Empty;
            HeightClassTxtBox.Text = String.Empty;
   
        }

        private void clickCloseBtn(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
