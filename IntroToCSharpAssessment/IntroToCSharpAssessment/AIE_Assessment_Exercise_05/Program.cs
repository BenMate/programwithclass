/*
 * Appendix 2 - Exercise 2: Sorting an Array (Descending)
 */


using System;

namespace AIE_Assessment_Exercise_05
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

            //todo changed from giving an int [] to a void (modifying the array instead of giving out an input)
             int[] Sorted = SortDescending(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{Sorted [ i ]}, ");
            }
             

            // TODO:
            // Write a function that accepts the integer array 'numbers' and outputs the sorted array to the console

            void SortDescending(int[] numbers)
            {
                bool isSorted = false;
                int lastUnsorted = numbers.Length - 1;
                int tmp = 0;
                
                while (!isSorted)
                {
                    isSorted = true;
                    for (int i = 0; i < lastUnsorted; i++)
                    {
                        if (numbers[i] > numbers [i + 1])
                        {
                            tmp = numbers[i];
                            numbers[i] = numbers [i + 1];
                            numbers[i + 1] = tmp;
                           

                            isSorted = false;
                        }
                    }
                    lastUnsorted--;
                }
                

            }
        }
    }
}
