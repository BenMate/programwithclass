/*
 * Appendix 2 - Exercise 1: Sum of Array
 */

using System;

namespace AIE_Assessment_Exercise_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input comma separated list of numbers");
            string lineOfText = Console.ReadLine();
            string[] values = lineOfText.Split(',');

            int[] numbers = new int[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                numbers[i] = Int32.Parse(values[i]);
            }

           //  int[] totalSum = Sum(numbers);

           // for (int i = 0; i < totalSum.Length; i++)
           // {

           //     Console.WriteLine(i);
           // }
            

            // TODO:
            // Write a function that accepts the integer array 'numbers' and 
            // returns the sum of the array

            static int[] Sum(int numbers)
            {
                int[] total = new int [numbers];



                //todo: loop through each number in the numbers array
                // add each number to the total.
                
                for (int i = 0; i < numbers; i++)
                {
                    //sum += arr[i];
                    total[i] += numbers;
                    
                }



                return total;
            }

        }
    }
}
