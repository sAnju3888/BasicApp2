namespace PolyLib
{
    public enum Usertype
    {
        Admin = 1,
        Customer = 2,
        Student
    }
    public enum Days
    {
        Sunday,//0
        Monday,//1
        Tueday,//2
        Wednesday,//3
        Thursday,//4
        Friday,//5
        Saturday//6 BY DEFAULT

    }
    public class Class1
    {


        public virtual void Animalsound()
        {
            Console.WriteLine("Animal gives you sound");
        }

        public void pay(int AccNo,int Ifsc,String cardholder)
        {
            // Debit card
            Console.WriteLine($"{cardholder} Your transaction has been completed through Debit card");
        }
        public void pay(String username)
        {
            // COD
            Console.WriteLine($"{username} Your transaction has been completed through cash on delivery");

        }

        public void pay(int Paytmoid)
        {
            //paytm
            Console.WriteLine("your transaction has been completed through paytm");
        }



    }

}