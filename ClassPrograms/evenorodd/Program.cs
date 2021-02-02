using System;

namespace evenorodd
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("enter a number to find out if it is even or odd");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("EVEN");
            }
            else         
            {
                Console.WriteLine("ODD");
            }








        }
    }
}
