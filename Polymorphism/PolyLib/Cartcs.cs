using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyLib
{
    public class Cartcs
    {
        public int CustID { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        private decimal _amt;
        public decimal Amt { get { return _amt; } set { _amt = value; } }
        public string Mode { get; private set; }
        public decimal CalculateAmt()
        {
            decimal amt = Price * Quantity;
            Amt = amt;
            return amt;
        }

        public decimal payment(string upiId)
        {
            Mode = "UPI";
            return Amt;
        }
        public decimal payment(long cardno,int cvv)
        {
            Mode = "Card";
            return Amt;

        }
        public void payment()
        {
            Mode = "cash";
            Console.WriteLine("LIDJ");

        }




    }
}
