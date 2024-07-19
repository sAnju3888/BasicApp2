using System;

namespace BasicApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ans = 'Y';
            do
            {
                Console.WriteLine("\n1.Add New Student \n2.Edit a Student \n3.Exit");
                int userChoice = Convert.ToInt32(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        int rno = Student.GenerateRollNo();
                        Console.WriteLine($"The rollno= {rno}");

                        break;
                    case 2:
                        Console.WriteLine("Work in progress.....");
                        break;
                    case 3:
                        Environment.Exit(1);

                        break;

                }

                Console.WriteLine("Do u want to add one more student?");
                ans = Convert.ToChar(Console.ReadLine());
                if (ans == 'N')
                    Environment.Exit(1);
            }
            while (ans == 'Y');
            Console.Read();
        }
    }
}