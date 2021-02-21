using System;

namespace Rand_03_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            String name;
            int age = 21;

            Console.WriteLine("Whats your name?");
            name = Console.ReadLine();

            

            //changing this "name" will change the outcome
            SayHi(name, age);
            

            Console.ReadLine();
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine($"Hello {name} Whats Goin on!");
            Console.WriteLine($"You are {age} years old.");

        }
    }
}
