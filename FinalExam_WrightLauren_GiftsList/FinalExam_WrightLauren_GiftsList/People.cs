using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam_WrightLauren_GiftsList
{
    public class People: IDisplayable
    {
        //fields
        public string Name { get; set; }
        public string Relationhsip { get; set; }
        public double Budget { get; set; }

        //list of gifts
        public List<Gifts> giftList { get; set; }


        //constructors
        public People() { }

        public People(string n, string r, double b)
        {
            Name = n;
            Relationhsip = r;
            Budget = b;
            giftList = new List<Gifts>();
        }

        public string GetDisplay()
        {
            string s = "Person: " + Name + "\r\nRelationship: " + Relationhsip + "\r\nBudget: " + Budget + "\r\nTotal: " + sumGifts()+ "\r\n\r\n";
            return s;
        }

        public double sumGifts()
        {
            double sum = 0;

            for (int x = 0; x < giftList.Count; x++)
            {
                sum += giftList[x].TotalPrice;
            }
            return sum;
        }



    }
}
