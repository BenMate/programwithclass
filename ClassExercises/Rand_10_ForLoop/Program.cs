using System;

namespace Rand_10_ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            ////same thing as the foor loop
            
            //int a = 1;
            //while ( a <= 5)
            //{
            //    Console.WriteLine(a);
            //    a++;
            //} 

            ////same thing as the for loop

            //for (int i = 1; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            int[] luckyNumbers = { 4, 8, 3, 2, 34, 23 };

            for (int i = 0; i < luckyNumbers.Length ; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }


        }
    }
}
