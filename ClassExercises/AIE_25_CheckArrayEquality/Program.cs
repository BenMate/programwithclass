using System;

namespace AIE_25_CheckArrayEquality
{
    class Program
    {
        // TODO: Write the CheckArrayEquality function here
        static int[] CheckArrayEquality(int[] numbers1)

        {
            for (int i = 0; i < numbers1; i++)
            {


            }


        }

        static void Main(string[] args)
        {
            var numbers1 = new int[] { 10, 3, 6, 6, 4, 8, 1, 7 };
            var numbers2 = new int[] { 10, 3, 6, 6, 4, 8, 1, 7 };
            var numbers3 = new int[] { 10, 3, 6, 6, 6, 8, 1, 7 };
            Console.WriteLine(CheckArrayEquality(numbers1, numbers2)); // true
            Console.WriteLine(CheckArrayEquality(numbers1, numbers3)); // false
        }
    }
}
