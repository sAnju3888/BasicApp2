using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpLib
{
    public class Dept
    {
        private int _deptno;
        public int Deptno
        {
            get { return _deptno; }
            set
            {
                if (value <= 0)
                {
                    //throw new ArgumentOutOfRangeException("value");
                    Console.WriteLine("INVALID DEPT NO!!!!!!!!!!!!!");
                    Console.Read();
                    Environment.Exit(1);
                }
                else
                {
                    _deptno = value;
                }
            }
        }
        private string _dname;
        public string Deptname
        {
            get { return _dname; }
            set {
                if (string.IsNullOrEmpty(value) || value.Length < 4)
                {
                    Console.WriteLine("ENter valid name greater than 4 character");
                    Console.WriteLine("Exciting.. press any key to continue");
                    Console.Read();
                    Environment.Exit(1);
                }
                else
                {
                    _dname = value;
                }
            }
        }
    }
}
