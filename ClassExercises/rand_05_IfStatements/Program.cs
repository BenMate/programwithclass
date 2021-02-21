using System;

namespace rand_05_IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(MaxNum(2, 35, 25));

            Console.ReadLine();

        }

        static int MaxNum(int num1, int num2, int num3)
        {
            int result;
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }
            return result;

        }

    }
}
