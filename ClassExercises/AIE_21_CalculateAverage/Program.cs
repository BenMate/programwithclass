﻿using System;

namespace AIE_21_CalculateAverage
{
    class Program
    {
        // TODO: Write the CalculateAverage function here
        static double CalculateAverage(int[] numbers) 
        {

            int total = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
                   
            }
            return total / (float)numbers.Length;
        }
        static void Main(string[] args)
        {
            var numbers = new int[] { 10, 3, 6, 6, 4, 8, 1, 7 };
            Console.WriteLine(CalculateAverage(numbers));
        }
    }
}
