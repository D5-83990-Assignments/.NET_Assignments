using System.Net.Cache;

namespace Que_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Accept();
            person.Print();
            Console.ReadLine();
 
        }
    }

    class Date
    {
        private int _Day;
        private int _Month;
        private int _Year;

        public Date() {    }

        public Date(int Day, int Month, int Year)
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
            Console.WriteLine("Date :- " + _Day + "/" + _Month + "/" + _Year);
        }

        public bool IsValid()
        {
            if ((_Day > 1 && _Day <= 31) && (_Month > 1 && _Month <= 12) && (_Year > 1 && _Year <= 9999))
            {
                return true;
            }
            else
                return false;
        }

        public string ToString()
        {
            return _Day + "/" + _Month + "/" + _Year;
        }

    }

    class Person
    {
        private string? _Name;
        private string? _Address;
        private bool _Gender;
        private Date? date;

        public Person() 
        {  
            date = new Date();
        }

        public Person(string name,string address,bool gender)
        {
            _Name = name;
            _Address = address;
            _Gender = gender;
            date = new Date();
            date.AcceptDate();
        }

        public void Accept()
        {
            Console.Write("Enter the name :- ");
            _Name = Console.ReadLine();
            Console.Write("Enter the address :- ");
            _Address = Console.ReadLine();
            Console.Write("Enter the gender:- ");
            _Gender = Convert.ToBoolean(Console.ReadLine());
            date.AcceptDate();
        }

        public Date? Date
        {
            get { return date; }
            set { date = value; }
        }


        public bool Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }


        public string? Address
        {
            get { return _Address; }
            set { _Address = value; }
        }


        public string? Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public void Print()
        {
            DateTime tod = DateTime.Today;
            Console.WriteLine("Name :- " + _Name);
            Console.WriteLine("Address :- " + _Address);
            Console.WriteLine("Gender :- " + _Gender);
            Console.WriteLine("Date of Birth :- " + date.ToString());
            if(date.Month <= Convert.ToInt32(tod.ToString("MM")))
            {
                Console.WriteLine("Age :- " + (Convert.ToInt32(tod.ToString("yyyy")) - date.Year));
            }
            else
            {
                Console.WriteLine("Age :- " + ((Convert.ToInt32(tod.ToString("yyyy")) - 1) - date.Year));
            }
        }

    }
}
