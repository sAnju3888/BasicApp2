using System;

namespace MoreonDelegatesApp
{
    delegate void coma(string message);
    delegate int AddNos(int i, int j);
    public class Program
    {
        static void Main(string[] args)
        {
            coma h = delegate (string message)
            {
                Console.WriteLine(message);
            };

            h("oooohiiiiii");

            //AddNos add = (int x, int y) => x + y;
            //Console.WriteLine(add(2,4));

            //Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> check = (i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16) =>
            //  {
            //      return (i1 + i2 + i3 + i4 + i5) * (i6 + i7 + i8 + i9);
            //  };
            //Console.WriteLine(check(1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16));

            //Predicate<int> FindEven = (i) =>
            //{
            //    bool status = true;
            //    if (i % 2 == 0)
            //    {
            //        status = false;
            //    }
            //    return status;
            //};
            //bool d = FindEven(20);
            //Console.WriteLine(d);
            List<string> list = new List<string>();
            list.Add("sikdfbjdfh");
            list.Add("vjhbsvhbdfv");
            list.Add("sdvkhbdfvbhk");
            list.Add("sdert");
            list.Add("hukum");

            List<String> ok = list.FindAll(e => e.Length == 5);
            foreach (string s in ok)
            {
                Console.WriteLine(s);
            }

            //int i = list.Find(e => e == 1);
            //List<int> o = list.FindAll(e => e % 2 == 0);





        }
        }
    }
