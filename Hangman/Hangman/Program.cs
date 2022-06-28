using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SetUpGame();

            bool keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    Console.Write("Do you want to play hangmans game?\n" +
                        "-1: Exit\n" +
                        "1: Yes");
                    Console.WriteLine();

                    string playOrExitStr = Console.ReadLine() ?? "";

                    switch (playOrExitStr)
                    {

                        case "-1":
                            keepAlive = false;
                            break;

                        case "1":
                            HangmansGame();
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid input!");
                            Console.ResetColor();
                            break;
                    }
                }

                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid assignment number!");
                    Console.ResetColor();
                }
            }
        }

        static void SetUpGame()
        {
            LoadWordsFromFile();
        }

        static string[] wordsToGuessArray;
        static string wordsFilePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\wordsHangman.txt";   // Directory.GetCurrentDirectory() + "\\wordsHangman.txt";
        static void LoadWordsFromFile()
        {
            using (StreamReader sr = File.OpenText(wordsFilePath))
            {
                // load in the textfile, convert it to lowercase and split it
                string[] s = sr.ReadToEnd().ToLower().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                wordsToGuessArray = s;
            }
        }


        const int guessesMax = 10;
        //static int guessesCurrent = 0;
        static Random rnd = new Random();

        static void HangmansGame()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            int guessesCurrent = 0;

            string wordCurrent = wordsToGuessArray[rnd.Next(wordsToGuessArray.Length)];

            // number of unique letters in the word, if the word contains a space, then remove one unique letter, since it counts as one
            char[] lettersCorrect = new char[wordCurrent.Contains(' ') ? wordCurrent.Distinct().Count() - 1 : wordCurrent.Distinct().Count()];
            int foundLetters = 0;
            StringBuilder lettersIncorrect = new StringBuilder();



            while (guessesCurrent < guessesMax)
            {
                Console.Write("Enter a single char to see if the word contains the letter\n" +
                    "Or enter a string to guess the word\n" +
                    "Or write \"-1\" to give up");
                Console.WriteLine();
                Console.WriteLine();
                DrawHangman(wordCurrent, lettersCorrect, lettersIncorrect, guessesCurrent);

                string guessedWordOrChar = Console.ReadLine() ?? "";
                bool valid = false;

                switch (guessedWordOrChar)
                {
                    case "-1":
                        Console.WriteLine($"You gave up guessing the word \"{wordCurrent}\" after {guessesCurrent} tries");
                        return;

                    case "":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You need to write something!");
                        Console.ResetColor();
                        break;

                    default:
                        // If the guess does not only contains letters and spaces, or if it only contain spaces
                        if (!guessedWordOrChar.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)) || (guessedWordOrChar.Distinct().Count() == 1 && guessedWordOrChar[0] == ' '))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid guess!");
                            Console.ResetColor();
                            break;
                        }
                        valid = true;
                        break;
                }

                if (valid)
                {
                    guessesCurrent++;
                    guessedWordOrChar = guessedWordOrChar.ToLower();    // Incase the person wrote an uppercase letter, since the word to guess is a lowercase one
                    if (guessedWordOrChar.Length == 1)  // If they only entered one letter, see if the word contains it
                    {
                        if (lettersCorrect.Contains(guessedWordOrChar[0]) || lettersIncorrect.ToString().Contains(guessedWordOrChar))
                        {
                            Console.WriteLine("You have already guessed this letter");
                            guessesCurrent--;
                        }

                        else
                        {

                            if (wordCurrent.Contains(guessedWordOrChar))
                            {
                                lettersCorrect[foundLetters++] = guessedWordOrChar[0];
                            }

                            else
                            {
                                lettersIncorrect.Append(guessedWordOrChar);
                            }
                        }

                        //if the player has guessed all the letters but not guessed the word, they have found the word
                        if (foundLetters == lettersCorrect.Length)
                        {
                            Console.WriteLine($"Congratulations, you found all letters that makes up the word \"{wordCurrent}\"!");
                            Console.WriteLine();
                            return;
                        }
                    }

                    else    //if length > 1
                    {
                        if(wordCurrent == guessedWordOrChar)
                        {
                            Console.WriteLine($"Congratulations, you found \"{wordCurrent}\" in {guessesCurrent} tries!");
                            Console.WriteLine();
                            return;
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"You were unable to guess the word \"{wordCurrent}\" in {guessesMax} tries");
            Console.WriteLine();
            return;
        }


        static void DrawHangman(string wordToFind, char[] foundLetters, StringBuilder incorrectLetters, int currentGuesses)
        {
            string s = "";
            // for each letter that you have found or not found, write them out. Also draw spaces as spaces
            for(int i = 0; i < wordToFind.Length; i++)
            {
                if (wordToFind[i] == ' ')
                {
                    s += " ";
                }
                else if (foundLetters.Contains(wordToFind[i]))
                {
                    s += wordToFind[i];
                }
                else
                {
                    s += "_";
                }
            }

            Console.WriteLine(s);

            Console.Write($"Letters tried: ");
            for(int i = 0; i < foundLetters.Length; i++)
            {
                Console.Write(foundLetters[i]);
            }

            Console.WriteLine($"\t{incorrectLetters.ToString()}");
            Console.WriteLine($"Tries left: {guessesMax - currentGuesses}");
        }

    }


}
