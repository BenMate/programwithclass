using System;

namespace Rand_08_WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int something = 6;

            do
            {
                Console.WriteLine(something);
                something++;

            }while (something <= 5);

            Console.ReadLine();
        }
    }
}
