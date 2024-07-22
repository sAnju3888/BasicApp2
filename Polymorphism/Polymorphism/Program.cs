using System;
using PolyLib;

namespace Polymorphism
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //Console.WriteLine("check_working or not");
            //Class1 a1 = new Class1();
            //Class1 a2 = new Class2();
            //Class1 a3 = new Class3();
            //a1.Animalsound();
            //a2.Animalsound();
            //a3.Animalsound();


            //a1.pay(1234444);
            //a1.pay(12378911, 2341596, "Sharukh");
            //a1.pay("Hridhik");
            
            Console.WriteLine("1.Login as admin, 2. Login as customer");
            Usertype usertype = (Usertype)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(usertype);

            switch(usertype)
            {
                case Usertype.Admin:
                    Console.WriteLine("\n 1. ADD items \n 2) Update items \n 3) view items \n 4)Delete items");
                    break;
                case Usertype.Customer:
                    Console.WriteLine("\n 1. ADD items \n 2) Update items \n 3) view items \n 4)Delete items");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch(choice)
                    
                    {
                        case 1:
                            AddItemsToCart();
                            break;
                        default:
                            break;

                    }
                    break;
                case Usertype.Student:
                    Console.WriteLine("\n 1. ADD items \n 2) Update items \n 3) view items \n 4)Delete items");
                    break;

            }
                  
            
             
                
         }

        private static void AddItemsToCart()
        {
            Cartcs c = new Cartcs();
            Console.WriteLine("Enter CustID");
            c.CustID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Quantity");
            c.Quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter price");
            c.Price = Convert.ToInt32(Console.ReadLine());

            decimal amt = c.CalculateAmt();
            Console.WriteLine($"You have to pay Rs.{amt}");

            Console.WriteLine("Choose mode of payment ");
            Console.WriteLine("1)cash \n 2) card \n 3)UPI id");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    //c.Mode = "cash";
                    c.payment();
                    break;
                case 2:
                    //c.Mode = "card";
                    Console.WriteLine("Enter card no:");

                    long cardno = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Enter CVV");
                    int cvv = Convert.ToInt32(Console.ReadLine());
                    decimal Amt = c.payment(cardno, cvv);
                    Console.WriteLine($"You have paid a {Amt} by {c.Mode}");
                    break;
                case 3:
                    Console.WriteLine("Enter UPI");
                    string upi = Console.ReadLine();
                    Amt = c.payment(upi);
                    Console.WriteLine($"You have paid a {Amt} by {c.Mode}");
                    break;
                default:
                    break;

            }
        }
    }
}
