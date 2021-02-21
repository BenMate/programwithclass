using System;

namespace Rand_04_ReturnMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            //calls the method
            Console.WriteLine(cube(5));



            Console.ReadLine();
        }

        static int cube(int num)
        {
            int result = num * num * num;

            //tells the methord to return result back to the caller
            //breaks out of method
            return result;

        } 
        
    }
}
