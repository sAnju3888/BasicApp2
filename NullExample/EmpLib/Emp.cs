namespace EmpLib
{
    public class Emp
    {
        static int _empno;
        string? _fname, _lname, _city;
        long? _adharno;

        static Emp()
        {
            _empno = 0;
            Console.WriteLine("empno initialized....");
        }

        public string Fname
        {
            get { return _fname; }
            set { _fname = value; }
        }
        public int Empno
        {
           // READ ONLY 
            get
            {
                _empno++;
                return _empno;
            }
        }
        public int AadharId
        {
            //Write only
            set { _adharno = value; }
        }



        private DateTime _doj;

        public DateTime JoiningDate
        {
            get { return _doj; }
            set { _doj = value; }
        }

        public void PrintData()
        {
            Console.WriteLine(this._fname);
            Console.WriteLine(this._lname);
            Console.WriteLine(this._city);
            Console.WriteLine(this._adharno);

        }

    }
}