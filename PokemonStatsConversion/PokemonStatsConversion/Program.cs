/**
 * author: Lauren Wright
 * program: Pokemon Stat Converter
 * 
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonStatsConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            double weight;
            double height;
            double convWeight;
            double convHeight;
            const double OZRATE = 35.274;
            const double INRATE = 39.3701;
            String weightClass;
            String heightClass;
            String name;

            

            //if command line
            if (args.Length != 0)
            {

                //name of the pokemon
                name = args[0];

                //weight of the pokemon
                height = Double.Parse(args[1]);

                //height of the pokemon
                weight = Double.Parse(args[2]);

            }
                
            //if command line
            else
            {
                //get pokemon name
                Console.Write("Enter the pokemon's name: ");
                name = Console.ReadLine();

                //get pokemon weight
                Console.Write("Enter the weight of " + name + ": ");
                String w = Console.ReadLine();
                weight = Double.Parse(w);
                weight = Math.Round(weight, 2);

                //get pokemon height
                Console.Write("Enter the height of " + name + ": ");
                String h = Console.ReadLine();
                height = Double.Parse(h);
                height = Math.Round(height, 2);
            }
                   
            //display current stats
            Console.WriteLine("\nHere are the current stats for " + name);
            Console.WriteLine("\tWeight: " + weight + " kg");
            Console.WriteLine("\tHeight: " + height + " m");
            
            //convert
            convHeight = height*INRATE;
            convWeight = weight*OZRATE;

            //round
            convWeight = Math.Round(convWeight, 2);
            convHeight = Math.Round(convHeight, 2);

            //get height and weight classifications
            weightClass = WeightClass(convWeight);

            heightClass = HeightClass(convHeight);

            //display converted stats
            Console.WriteLine("\nHere are the converted stats for " + name);
            Console.WriteLine("\tWeight: " + convWeight + " oz");
            Console.WriteLine("\tWeight Classification: " + weightClass);
            Console.WriteLine("\tHeight: " + convHeight + " in");
            Console.WriteLine("\tHeight Classification: " + heightClass);
            Console.ReadLine();


            

        }

        //method returns height classification
        static String HeightClass(double convHeight)
        {
            //declare variables
            String heightClass = " ";

            //identify height classification
            if (convHeight < 30)
            {
                heightClass = "Short";

            }//end if

            else if (convHeight >= 30 && convHeight <= 49)
            {
                heightClass = "Normal";
            }//ebd else if

            else if (convHeight >= 50)
            {
                heightClass = "Tall";
            }//end else if


            return heightClass;
        
        }//end heightClass


        //this method returns weight classification
        static String WeightClass(double convWeight)
        {
            //declare variables
            String weightClass = " ";


            //identify weight classification
            if (convWeight < 100)
            {
                weightClass = "Extra Small";

            }//end if

            else if (convWeight >= 100 && convWeight < 500)
            {
                weightClass = "Normal";
            }//ebd else if

            else if (convWeight >= 500)
            {
                weightClass = "Extra Large";
            }//end else if


            return weightClass;
        }//end weightClass
    }//end main
}//end program
