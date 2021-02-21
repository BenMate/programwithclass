using System;

namespace Rand_09_GuessingGameChallange
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "panda";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            Console.WriteLine("Hint....Black and White Animal....");
            Console.WriteLine($"You have {guessLimit} guesses");

            do
            {
                guessCount++;
                Console.WriteLine($"#: {guessCount} ");
                Console.WriteLine($"Enter Guess:");
                guess = Console.ReadLine();
                
            }
            //checks if the guess isnt the secret word and the guess is less then the limit, continue loop.
            while (guess != secretWord && guessCount < guessLimit);
            {
                if (guessCount >= guessLimit )
                {
                    outOfGuesses = true;
                }
                //if the guess is the secret word
                if (guess == secretWord)
                {
                    Console.WriteLine("You Win!");
                    return;
                }              
            }
            //doesnt need the "== true", true is default.
            if (outOfGuesses == true )
            {
                Console.WriteLine("You Ran out of guesses");
                Console.WriteLine("You LOOOOOOOSE");
            }

            Console.ReadLine();

        }
    }
}
