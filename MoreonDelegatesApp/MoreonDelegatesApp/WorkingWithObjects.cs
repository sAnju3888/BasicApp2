using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericLib;
namespace MoreonDelegatesApp
{
    internal class WorkingWithObjects
    {
        static List<Employee> empList = new List<Employee>();

        static void NewEmployee(Employee emp)
        //static void NewEmployee(int empid,string ename,int basicSal)
        {

            empList.Add(emp);
            
            //   empList.Add(new Employee() {Empid=empid,EmpName=ename,BasicSal=basicSal });

        }
        public static void IntialiseData()
        {
            empList.Add(new Employee() { EmpId = 1,EmpName = "A",BasicSal=10000});
            empList.Add(new Employee() { EmpId = 2, EmpName = "B", BasicSal = 12200 });
            empList.Add(new Employee() { EmpId = 3, EmpName = "AB", BasicSal = 11000 });
            empList.Add(new Employee() { EmpId = 4, EmpName = "AC", BasicSal = 13000 });
            empList.Add(new Employee() { EmpId = 5, EmpName = "AD", BasicSal = 1000 });

        }

        public static Employee FindEmployee(int id)
        {
            Employee foundemployee = empList.Find(e => e.EmpId == id);
            Console.WriteLine($"{foundemployee.EmpId}Available");
            return foundemployee;

        }

        public static void  DeleteEmployee(int id)
        {
            Employee del_id = empList.Find(e => e.EmpId == id);
            empList.Remove(del_id);
        }
        static List<Employee> ShowList()
        {
            return empList;
        }

        static List<Employee> FindAllEmployeesBySal(int bs)
        {
            return empList.FindAll(e => e.BasicSal == bs);
        }

        static void Main(string[] args)
        {
            IntialiseData();
            Console.WriteLine("1. Find  \n 2.Add \n 3.Delete \n 4. Show List");
             int c = Convert.ToInt32(Console.ReadLine());
            switch(c)
            {
                case 1:
                    Console.WriteLine("Enter Empid:");
                    int empid = Convert.ToInt32(Console.ReadLine());
                    FindEmployee(empid);

                    break;
                case 2:
                    Console.WriteLine("Enter Empid");
                    empid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Employee Name");
                    string empname = Console.ReadLine();

                    Console.WriteLine("Enter Basic Salary");
                    int basicsaalary = Convert.ToInt32(Console.ReadLine());
                    Employee em = new Employee();
                    em.EmpId = empid;
                    em.EmpName = empname;
                    em.BasicSal = basicsaalary;


                    Console.WriteLine(em.EmpId);
                    Console.WriteLine(em.EmpName);
                    Console.WriteLine(em.BasicSal);
                    NewEmployee(em);
                    break;
                case 3:
                    int rem_id = Convert.ToInt32(Console.ReadLine());
                    DeleteEmployee(rem_id);
                    break;
                case 4:
                    List<Employee> elist = ShowList();
                    elist.ForEach(e =>
                    {
                        Console.WriteLine(e.EmpId);
                        Console.WriteLine(e.EmpName);
                        Console.WriteLine(e.BasicSal);
                    });
                    break;
                case 5:
                    Console.WriteLine("Enter the salary to find employee for");
                    int sal  = Convert.ToInt32(Console.ReadLine());
                    int cnt = empList.FindAll(e => e.BasicSal == sal).Count();
                    if (cnt == 1)
                    {
                        FindEmployee(sal);
                    }
                    else if (cnt > 1)
                    {
                        FindAllEmployeesBySal(sal);

                    }
                    else
                    {
                        Console.WriteLine("Not in Range");
                    }
                    break;

                default:
                    break;
            }
        }
    }
}
