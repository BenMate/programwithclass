using System;
using System.Linq;
    
namespace AIE_24_MinMax
{
    class Program
    {
        static int[] FindMinMax(int[] numbers)
        {
            return new int[] { numbers.Min(), numbers.Max() };
        }



        static void Main(string[] args)
        {

            var numbers = new int[] { 10, 3, 6, 6, 4, 8, 1, 7 };
            var minmax = FindMinMax(numbers);

            Console.WriteLine(minmax[0]); // 1
            Console.WriteLine(minmax[1]); // 10



        }
    }
}
