using System;
using EmpLib;
namespace NullExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Emp employee = new Emp();
            //Console.WriteLine("Enter first name ");
            //string? firstname = Console.ReadLine();
            //Console.WriteLine("Enter LastName");
            //string? lastname = Console.ReadLine();
            //Console.WriteLine("Enter City");
            //string? city = Console.ReadLine();
            //Console.WriteLine("Enter Aadhar No");
            //long? adhar = Convert.ToInt64(Console.ReadLine());
            //int empno = employee.NewEmployee(firstname, lastname, city, adhar);
            //Console.WriteLine("Printing details... You entered the following");
            //employee.PrintData();
            //Console.WriteLine($"Generated EmployeeNumber={empno}");

            //Console.Read();
            Dept d = new Dept();
            Console.WriteLine("Enter your Dept no");
            d.Deptno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Dept name");
            d.Deptname = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"the dept no is {d.Deptno}");
            Console.WriteLine($"the dept name is{d.Deptname}");
            Console.WriteLine("----------------------=======");
            Emp e = new Emp();
            Console.WriteLine("Enter First Name");
            e.Fname = Console.ReadLine();
            Console.WriteLine($"Thanks for the input .. ur empid ={e.Fname}");
            Console.WriteLine("Enter date in format dd/mm/yyyyy");
            e.JoiningDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(e.JoiningDate);

            Console.WriteLine(e.JoiningDate.Day);
            Console.WriteLine(e.JoiningDate.Month);
            Console.WriteLine(e.JoiningDate.Year);

        }
    }
}