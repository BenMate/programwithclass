/*
 * Appendix 1 - Exercise 2: Fibonacci
 */

using System;

namespace AIE_Assessment_Exercise_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfElements = 0;

            
            if (args.Length < 1) args = new string[] { "13" };
            



            //grabing number from the argument
            numberOfElements = Int32.Parse(args[0]);

           int[] sequence = Fibonacci(numberOfElements);
            


            for (int i = 0; i < sequence.Length; i++) 
            {
                
                Console.WriteLine(sequence[i]);
            }



            // TODO:
            // Write a function that will, given an integer n, calculate the first n numbers in the 
            // Fibonacci sequence given starting elements of (0, 1). 
            // Output your result to the console

            static int[] Fibonacci(int numberOfElements)
            {
                

                int[] seq = new int[numberOfElements];

                seq[0] = 0;
                seq[1] = 1;

                for (int i = 2; i < numberOfElements; i++)
                {
                    seq[i] = seq[i - 1] + seq[i - 2];
                }

               
                return seq;
            }


        }
    }
}
