using System;

namespace ClassPrograms
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter 3 numbers");
            int anumber = int.Parse(Console.ReadLine());
            int bnumber = int.Parse(Console.ReadLine());
            int cnumber = int.Parse(Console.ReadLine());

            if (anumber > bnumber)
            {
                if (anumber > cnumber)
                {
                    Console.Write("The 1st Number is the greatest among three.");
                }

                else
                {
                    Console.Write("The 3rd Number is the greatest among three.");
                }
            }
            else if (bnumber > cnumber)
            {
                Console.Write("The 2nd Number is the greatest among three");
            }
            else
            {
                Console.Write("The 3rd Number is the greatest among three");
            }
















        }
    }
}