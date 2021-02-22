using System;

namespace Rand_02_Aray
{
    class Program
    {
        static void Main(string[] args)
        {
            //index               0   1  2   3   4   5
            int[] luckyNumbers = {4, 10, 23, 17, 19, 22 };
            string[] friends = new string[2];
            friends[0] = "jim";
            friends[1] = "Power";




            luckyNumbers[1] = 9001;


            Console.WriteLine( luckyNumbers[1]);
            Console.WriteLine(friends[1]);





            Console.ReadLine();
        }
    }
}
