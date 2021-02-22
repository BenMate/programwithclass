/*
 * Appendix 1 - Exercise 1: Adding Two Numbers
 */

using System;

namespace AIE_Assessment_Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            float firstNumber = 0f;
            float secondNumber = 0f;


            if (args.Length < 2) args = new string[] { "3.1", "2.7" };

            firstNumber = float.Parse(args[0]);
            secondNumber = float.Parse(args[1]);

            AddNumbers(firstNumber, secondNumber);
            Console.WriteLine(firstNumber + secondNumber);

            // TODO:
            // Write a function that will sum the two input floating point numbers
            // and return an integer
            // Output your result to the console 

            static int AddNumbers(float firstNumber, float secondNumber)
            {
                return (int)firstNumber + (int)secondNumber;
            }

        }
    }
}
