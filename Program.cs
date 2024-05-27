namespace Que_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice ;
            do 
            {
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Substraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("0. EXIT");
                Console.WriteLine();
                Console.Write("Enter the choice :- ");
                choice = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine();

                int z, x, y;

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Thanks for using our app !!!!");
                        break;

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
                        Console.WriteLine("Substraction of number :- " + z);
                        break;

                    case 3:
                        Console.Write("Enter the first number :- ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the second number :- ");
                        y = Convert.ToInt32(Console.ReadLine());
                        z = x * y;
                        Console.WriteLine("Multiplication of number :- " + z);
                        break;

                    case 4:
                        Console.Write("Enter the first number :- ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the second number :- ");
                        y = Convert.ToInt32(Console.ReadLine());
                        z = x / y;
                        Console.WriteLine("Division of number :- " + z);
                        break;

                    default:
                        Console.WriteLine("Please make valid choice !!!!");
                        break;
                }
                Console.ReadLine();
            } while (choice != 0);
        }
    }
}
