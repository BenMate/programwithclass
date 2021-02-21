using System;

namespace Rand_09_GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "donkey";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            Console.WriteLine("Guess the word!");

            //while guess doesnt = the word
            while (guess != secretWord && !outOfGuesses)
            {
                //if guesscount is less then the guess limit
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("Enter Guess");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }    
                
            }
            //CHECKING IF OUT OF GUESSES
            if(outOfGuesses)
            {
                Console.WriteLine("YOU LOSE");
            }
            else                  
            {
                Console.WriteLine("You Win!");
            }

            Console.ReadLine();
        }
    }
}
