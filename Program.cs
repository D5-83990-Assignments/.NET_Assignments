using System.Diagnostics;
using System.Linq.Expressions;

namespace Que_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Substraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine();
            Console.Write("Enter the choice :- ");
            int choice = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine();

            int z,x,y;

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the first number :- ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the second number :- ");
                    y = Convert.ToInt32(Console.ReadLine());
                    z = x + y;
                    Console.WriteLine("Addition of number :- " + z);
                    break;

                case 2:
                    Console.Write("Enter the first number :- ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the second number :- ");
                    y = Convert.ToInt32(Console.ReadLine());
                    z = x - y;
                    Console.WriteLine("Substraction of number :- "+z);
                    break;

                case 3:
                    Console.Write("Enter the first number :- ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the second number :- ");
                    y = Convert.ToInt32(Console.ReadLine());
                    z = x * y;
                    Console.WriteLine("Multiplication of number :- "+z);
                    break;

                case 4:
                    Console.Write("Enter the first number :- ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the second number :- ");
                    y = Convert.ToInt32(Console.ReadLine());
                    z = x / y;
                    Console.WriteLine("Division of number :- "+z);
                    break;

                default:
                    Console.WriteLine("Please make valid choice !!!!");
                    break;
            }
            Console.ReadLine();

        }
    }
}
