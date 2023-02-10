using System;

namespace Program
{
    class HangTheMan
    {
        static void Main(string[] args)
        {
            string[] words = { "meme", "game", "code", "bungie", "metalgear" };
            string[] hints = { "a piece of information passed through generations", "we gamers have a love/hate relationship with these", "how this game was made", "the dream company of this game's coder", "hit 80's NES stealth game series that lasted until the 2015" };
            
            Random random = new Random();

            int wordIndex = random.Next(words.Length);
            string wordToGuess = words[wordIndex];
            char[] guessedWord = new char[wordToGuess.Length];
            int lives = 6;

            for (int i = 0; i < wordToGuess.Length; i++)
            {
                guessedWord[i] = '_';
            }

            while (lives > 0)
            {
                Console.WriteLine("Your Current Word Is.... ");
                foreach (char c in guessedWord)
                {
                    Console.Write(c + " ");
                }
                Console.WriteLine();
                Console.WriteLine("Lives: " + lives);
                Console.WriteLine();
                Console.WriteLine("Guess a letter;");

                char userGuess = char.Parse(Console.ReadLine());
                bool correctGuess = false;
                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    if (wordToGuess[i] == userGuess)
                    {
                        guessedWord[i] = userGuess;
                        correctGuess = true;
                    }
                }

                if (!correctGuess)
                {
                    lives--;
                    Console.WriteLine("*buzzer noise* you are INCORRECT! Here's a hint: " + hints[wordIndex]);
                    Console.WriteLine();
                }

                if (!guessedWord.Contains('_'))
                {
                    Console.WriteLine("Omedetou! ");
                    Console.WriteLine("Omedetou! ");
                    Console.WriteLine("Omedetou! ");
                    Console.WriteLine("Omedetou! ");
                    Console.WriteLine("Omedetou! ");
                    Console.WriteLine("Omedetou! ");
                    Console.WriteLine("Omedetou! ");
                    Console.WriteLine("Omedetou! ");
                    Console.WriteLine("*Penguin noises*! ");
                    Console.WriteLine("Omedetou! ");
                    Console.WriteLine("Omedetou! ");
                    Console.WriteLine("Omedetou! ");
                    Console.WriteLine("Omedetou! ");
                    Console.WriteLine("Omedetou! Omedetou!");
                    Console.WriteLine("You Win! ");
                    break;
                }
            }

            if (lives == 0)
            {
                Console.WriteLine("for the crime of not being able to guess the word............ This man shal be HANGED!");
                Console.WriteLine("You Lose! ");
            }
        }
    }
}