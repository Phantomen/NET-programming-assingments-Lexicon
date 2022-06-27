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
        const int guessesMax = 10;
        static int guessesCurrent = 0;

        static Random rnd = new Random();

        static string[] wordsToGuessArray;
        ////static string wordCurrent = "";

        //static StringBuilder lettersIncorrect;
        //static char[] lettersCorrect;

        static string wordsFilePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\wordsHangman.txt";   // Directory.GetCurrentDirectory() + "\\wordsHangman.txt";

        static void Main(string[] args)
        {
            Start();

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
                    //bool valid = true;
                    //bool gussedNumber = int.TryParse(guessedWordOrChar, out int num);
                    //ConsoleColor currentColor = Console.ForegroundColor;
                    //Console.ForegroundColor = ConsoleColor.Green;

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
                            //valid = false;
                            break;

                            //case "":
                            //    Console.ForegroundColor = ConsoleColor.Red;
                            //    Console.WriteLine("That is not a valid assignment number!");
                            //    Console.ResetColor();
                            //    break;

                            //default:
                            //    if (!guessedWordOrChar.All(char.IsLetter))
                            //    {
                            //        Console.ForegroundColor = ConsoleColor.Red;
                            //        Console.WriteLine("Invalid guess!");
                            //        Console.ResetColor();
                            //        valid = false;
                            //        break;
                            //    }
                            //    valid = true;
                            //    break;
                    }

                    //Console.ResetColor();
                    //Console.WriteLine("Hit any key to continue!");
                    //Console.ReadKey();
                    //Console.Clear();
                }

                catch
                {
                    //ConsoleColor currentColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid assignment number!");
                    Console.ResetColor();
                }
            }
        }

        static void Start()
        {
            LoadWordsFromFile();
        }

        static void LoadWordsFromFile()
        {
            using (StreamReader sr = File.OpenText(wordsFilePath))
            {
                string[] s = sr.ReadToEnd().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                wordsToGuessArray = s;

                //string[] s = sr.ReadToEnd().Split(new string[] {"\n"}, StringSplitOptions.RemoveEmptyEntries);
                //wordsToGuessArray = s;

                //string[] s = File.ReadAllLines(wordsFilePath);
                //wordsToGuessArray = s;

            }
        }

        static bool HangmansGame()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            bool playing = true;

            guessesCurrent = 0;

            string wordCurrent = /*"testing"; */wordsToGuessArray[rnd.Next(wordsToGuessArray.Length)];

            StringBuilder lettersIncorrect = new StringBuilder();
            char[] lettersCorrect = new char[wordCurrent.Contains(' ') ? wordCurrent.Distinct().Count() - 1 : wordCurrent.Distinct().Count()];
            int foundLetters = 0;

            while (playing && guessesCurrent < guessesMax)
            {

                Console.Write("Enter a single char to see if the word contains the letter\n" +
                    "Enter a string to guess the word\n" +
                    "Or write \"-1\" to give up");
                Console.WriteLine();
                Console.WriteLine();
                DrawHangman(wordCurrent, lettersCorrect, lettersIncorrect);



                string guessedWordOrChar = Console.ReadLine() ?? "";
                bool valid = false;
                //bool gussedNumber = int.TryParse(guessedWordOrChar, out int num);
                //ConsoleColor currentColor = Console.ForegroundColor;
                //Console.ForegroundColor = ConsoleColor.Green;


                switch (guessedWordOrChar)
                {

                    case "-1":
                        playing = false;
                        break;

                    case "":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That is not a valid assignment number!");
                        Console.ResetColor();
                        break;

                    default:
                        if (!guessedWordOrChar.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
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
                    guessedWordOrChar = guessedWordOrChar.ToLower();
                    if (guessedWordOrChar.Length == 1)
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

                        if (foundLetters == lettersCorrect.Length)
                        {
                            Console.WriteLine($"Congratulations, you found all letters that makes up the word \"{wordCurrent}\"!");
                            Console.WriteLine();
                            return true;
                        }
                    }

                    else//is a string
                    {
                        if(wordCurrent == guessedWordOrChar)
                        {
                            Console.WriteLine($"Congratulations, you found \"{wordCurrent}\" in {guessesCurrent} tries!");
                            Console.WriteLine();
                            return true;
                        }
                    }
                }

                Console.WriteLine();
                //Console.Clear();
            }



            Console.WriteLine($"You were unable to guess the word \"{wordCurrent}\" in {guessesMax} tries");
            Console.WriteLine();
            return false;
        }


        static void DrawHangman(string wordToFind, char[] foundLetters, StringBuilder incorrectLetters)
        {
            string s = "";
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


            Console.WriteLine($"Tries left: {guessesMax - guessesCurrent}");
        }

    }


}
