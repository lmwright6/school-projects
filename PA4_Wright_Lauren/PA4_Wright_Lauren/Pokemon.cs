using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA4_Wright_Lauren
{
    public class Pokemon
    {
        

        public string Name{get;set;}
        public int HP { get; set; }
        public string Type { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        
        private int rowSpot = 0;

        


        //empty constructor
        public Pokemon() { }


        public static bool Validate(string pName, string pHP, string pType, string pWeight, string pHeight)
        {
            bool isValid = true;

            isValid = nameValidate(pName);

            if(isValid == true)
            {
                isValid = HPValidate(pHP);
                   
                                   
                    if(isValid == true)
                    {
                        isValid = weightValidate(pWeight);

                        if(isValid == true)
                        {
                            isValid = heightValidate(pHeight);
                        }
                    }
                
            }

            return isValid;
            
        }

        public string OutString()
        {
            string output = ("\r\nName: " + Name + "\r\nHP: " + HP + "\r\nType: " + Type + "\r\nWeight: " + Weight + "\r\nHeight: " + Height);

            return output;   

        }

        public static bool heightValidate(string pHeight)
        {
            bool isValid;
            double tryHP;
            isValid = Double.TryParse(pHeight, out tryHP);

            if(isValid != true)
            {
                MessageBox.Show("Input a number for Height");
            }

            return isValid;
        }


        public static bool weightValidate(string pWeight)
        {
            bool isValid; 
            double tryHP;
            isValid = Double.TryParse(pWeight, out tryHP);

            if (isValid != true)
            {
                MessageBox.Show("Input a number for Weight");
            }

            return isValid;
        }

        
        public static bool nameValidate(string pName)
        {
            bool isValid = true;
            if(pName.Length < 3)
            {
                MessageBox.Show("Name must be atleast 3 characters");
                isValid = false;
            }

            return isValid;
        }

        public static bool HPValidate(string pHP)
        {
            bool isValid; ;
            int tryHP;
            isValid =  Int32.TryParse(pHP, out tryHP);

            if (isValid != true)
            {
                MessageBox.Show("Input a number for HP");
            }


            return isValid;
        }


        

                
    }
}
