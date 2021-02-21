using System;

namespace Rand_13_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //same as: string something = "";
            Book book1 = new Book();

            book1.title = "Harry Potter";
            book1.author = "Jk Rowling";
            book1.pages = 400;

            Book book2 = new Book();

            book2.title = "BensWorld";
            book2.author = "Ben The Man";
            book2.pages = 69;


            Console.WriteLine(book2.author);
            Console.ReadLine();
        }
    }
}
