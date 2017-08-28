using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam_WrightLauren_GiftsList
{
    public class Gifts: IDisplayable
    {
        //fields
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public double TotalPrice { get; set; }

        //constructors
        public Gifts() { }

        public Gifts(string n, double p, int q)
        {

            Name = n;
            Quantity = q;
            Price = p;
            TotalPrice = p * q;
        }

        public string GetDisplay()
        {
            string s = ("Name: " + Name + "\r\nPrice: " + Price + "\r\nQty: " + Quantity + "\r\nSubTotal: " + TotalPrice + "\r\n");
            return s;
        }

    }
}
