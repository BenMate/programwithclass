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

            //calls the sum function, outputs totalsum
            int totalSum = SumNumbers(numbers);
            Console.WriteLine(totalSum);


            // TODO:
            // Write a function that accepts the integer array 'numbers' and 
            // returns the sum of the array

            static int SumNumbers(int[] numbers)
            {
                
            //todo: loop through each number in the numbers array
                // add each number to the total.
                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    //sum += arr[i];
                    sum += numbers[i];
                    
                }
              
                return sum;
            }

        }
    }
}
