using System.Reflection;
using System.Xml.Linq;

namespace Que_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] arr = null ;
            CreateArray(arr);
            Console.ReadLine();
            
        }

        static void CreateArray(Student[] stdArr) 
        {
            Console.Write("Enter the size of an array :- ");
            int x = Convert.ToInt32(Console.ReadLine());
            stdArr = new Student[x];
            AcceptInfo(stdArr);
        }

        static void AcceptInfo(Student[] stdArr)
        {
            for(int i = 0; i < stdArr.Length; i++) 
            {
                stdArr[i] = new Student();
                stdArr[i].AcceptDetails();
            }
            PrintInfo(stdArr);
        }

        static void PrintInfo(Student[] stdArr)
        {
            foreach (Student std in stdArr)
            {
                std.PrintDetails();
            }
            ReverseArray(stdArr);
        }

        static void ReverseArray(Student[] stdArr)
        {
            Console.WriteLine("Reverse Array");
            for(int i = stdArr.Length-1; i >= 0; i--) 
            {
                stdArr[i].PrintDetails();
                Console.WriteLine();
            }
        }
    }

    struct Student
    {
        private string _Name;
        private int _Age;
        private bool _Gender;
        private int _Std;
        private char _Div;
        private double _Marks;

        public Student(string Name, int Age, bool Gender, int Std, char Div, double Marks)
        {
            _Name = Name;
            _Age = Age;
            _Gender = Gender;
            _Std = Std;
            _Div = Div;
            _Marks = Marks;
        }

        public void AcceptDetails()
        {
            Console.Write("Enter name of student :- ");
            _Name = Console.ReadLine();
            Console.Write("Enter age of student :- ");
            _Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter gender of student :- ");
            _Gender = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Enter std of student :- ");
            _Std = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter division of student :- ");
            _Div = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter marks of student :- ");
            _Marks =Convert.ToDouble(Console.ReadLine());
        }

        public double Marks
        {
            get { return _Marks; }
            set { _Marks = value; }
        }


        public char Div
        {
            get { return _Div; }
            set { _Div = value; }
        }


        public int Std
        {
            get { return _Std; }
            set { _Std = value; }
        }


        public bool Gender  
        {
            get { return _Gender; }
            set { _Gender = value; }
        }


        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }


        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public void PrintDetails()
        {
            Console.WriteLine(_Name + " " + _Age + " " + _Gender + " " + _Std + " " + _Div + " " + _Marks);
        }

    }
}
