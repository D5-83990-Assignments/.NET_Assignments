namespace Que_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date d1 = new Date(10,6,2001);
            Console.WriteLine(d1.ToString());
            Console.WriteLine(d1.IsValid());
            Console.ReadLine();


        }
    }

    class Date
    {
        private int _Day;
        private int _Month;
        private int _Year;

        public Date(int Day,int Month,int Year)
        {
            _Day = Day;
            _Month = Month;
            _Year = Year;
        }

        public void AcceptDate()
        {
            Console.Write("Enter the day :- ");
            _Day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the month :- ");
            _Month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the year :- ");
            _Year = Convert.ToInt32(Console.ReadLine());
        }

        public int Year
        {
            get { return _Year; }
            set { _Year = value; }
        }


        public int Month
        {
            get { return _Month; }
            set { _Month = value; }
        }


        public int Day
        {
            get { return _Day; }
            set { _Day = value; }
        }

        public void PrintDate()
        {
            Console.WriteLine("Date :- "+_Day + "/" + _Month + "/" + _Year);
        }

        public bool IsValid()
        {
            if((_Day > 1 && _Day<=31) && (_Month > 1 && _Month <= 12) && (_Year > 1 && _Year <= 9999) )
            {
                return true;
            }
            else
                return false;
        }

        public string ToString()
        {
            return _Day+"/"+_Month+"/"+_Year;
        }

    }
}
