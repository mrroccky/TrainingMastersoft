using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, operation, result;
            char exitChoice;

            Console.WriteLine("Enter First Number:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number:");
            num2 = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("\n*********************** Choose Operation *************************");
                Console.WriteLine("1 - Addition");
                Console.WriteLine("2 - Multiplication");
                Console.WriteLine("3 - Subtraction");
                Console.WriteLine("4 - Exit");
                Console.Write("Enter your choice: ");

                operation = int.Parse(Console.ReadLine());

                switch (operation)
                {
                    case 1:
                        result = num1 + num2;
                        Console.WriteLine("Addition of two numbers is: " + result);
                        break;
                    case 2:
                        result = num1 * num2;
                        Console.WriteLine("Multiplication of two numbers is: " + result);
                        break;
                    case 3:
                        result = num1 - num2;
                        Console.WriteLine("Subtraction of two numbers is: " + result);
                        break;
                    case 4:
                        Console.Write("Do you really want to exit Y/N: ");
                        exitChoice = char.Parse(Console.ReadLine());
                
                        if (exitChoice == 'y')
                        {
                            Console.WriteLine("Exiting program...");
                            return;
                        }
                        break;
                    default:
                        Console.WriteLine("chose valid option");
                        break;
                }

            } while (true);
        }
    }
}
