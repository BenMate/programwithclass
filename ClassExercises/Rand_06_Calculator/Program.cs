using System;

namespace Rand_06_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter an Operator eg: + - * /");
            string op = Console.ReadLine();
            

            Console.WriteLine("Enter another Number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());


            if (op == "+")
            {
                Console.WriteLine();
                Console.WriteLine(num1 + num2);
            }

            else if (op == "-")
            {
                Console.WriteLine();
                Console.WriteLine(num1 - num2);
            }

           else if (op == "*")
           {
                Console.WriteLine();
                Console.WriteLine(num1 * num2);
           }

            else if (op == "/")
            {
                Console.WriteLine();
                Console.WriteLine(num1 / num2);
            }
            else
            {
                
                Console.WriteLine("Invalid Operator use the examples.");
            }

            Console.WriteLine();
        }
    }
}
