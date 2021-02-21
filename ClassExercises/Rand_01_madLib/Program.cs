using System;

namespace Rand_01_madLib
{
    class Program
    {
        static void Main(string[] args)
        {
            string colour1, nouns1, noun1, adjective2, noun2, nouns2, noun3, verb1, name1, feeling1, feeling2, noun4;
           

            Console.WriteLine("Enter a colour: ");
            colour1 =  Console.ReadLine();

            Console.WriteLine("Enter a plural noun: ");
            nouns1 = Console.ReadLine();

            Console.WriteLine("Enter a noun: ");
            noun1 = Console.ReadLine();

            Console.WriteLine("Enter an adjective: ");
            adjective2 = Console.ReadLine();

            Console.WriteLine("Enter a noun: ");
            noun2 = Console.ReadLine();

            Console.WriteLine("Enter a plural noun: ");
            nouns2 = Console.ReadLine();

            Console.WriteLine("Enter a feeling: ");
            feeling1 = Console.ReadLine();

            Console.WriteLine("Enter a verb: ");
            verb1 = Console.ReadLine();

            Console.WriteLine("Enter a noun: ");
            noun4 = Console.ReadLine();

            Console.WriteLine("Enter a name: ");
            name1 = Console.ReadLine();

            Console.WriteLine("Enter a feeling: ");
            feeling2 = Console.ReadLine();

            Console.WriteLine("Enter a noun: ");
            noun3 = Console.ReadLine();
            

            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine($"roses are {colour1} ");
            Console.WriteLine($"{nouns1} are blue");
            Console.WriteLine($"I love my {noun1} because its very unique for its {adjective2} senensation");
            Console.WriteLine($"Sometimes all i can think about is {noun2} :D");
            Console.WriteLine($"I look outside and saw {nouns2} running around ");
            Console.WriteLine($"It was nice. I felt {feeling1} ");
            Console.WriteLine($"The next day i was {verb1} towards the bus.");
            Console.WriteLine($"I tripped and fell in {noun4} Everyone Laughed");
            Console.WriteLine($"at school {name1} was talking to me.");
            Console.WriteLine($"I Felt {feeling2} .....");
            Console.WriteLine($"School ended. When i got home i saw a {noun3} ");





            Console.ReadLine();
        }
    }
}
