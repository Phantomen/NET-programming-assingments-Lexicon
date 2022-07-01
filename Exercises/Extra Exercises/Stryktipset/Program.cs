using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stryktipset
{
    internal class Program
    {
        enum StryktipsWin
        {
            One = 0,
            X = 1,
            Two = 2
        }
        static string GetStryktipsString(StryktipsWin stw)
        {
            if (stw == StryktipsWin.One)
            {
                return "1";
            }
            else if (stw == StryktipsWin.X)
            {
                return "X";
            }
            else // (matchWin[0] == StryktipsWin.Two)
            {
                return "2";
            }
        }


        static int combinationOfMatches = 0;
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            bool playing = true;
            while (playing)
            {
                bool valid = false;
                int numberOfMatches = 1;

                while (!valid)
                {
                    try
                    {
                        Console.WriteLine("Please input an int that is larger than 0\n" +
                            "Or enter -1 to exit");
                        numberOfMatches = int.Parse(Console.ReadLine());

                        if (numberOfMatches == -1)
                        {
                            playing = false;
                            break;
                        }
                        else if (numberOfMatches <= 0)
                        {
                            Console.WriteLine("That is not a valid amount of matches");
                        }
                        else
                        {
                            valid = true;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("That is not a valid amount of matches");
                    }
                }

                combinationOfMatches = 0;
                Console.WriteLine($"\nThis is all the unique way the matches can go for {numberOfMatches} number of matches");
                Stryktips(numberOfMatches, new StryktipsWin[numberOfMatches]);
                Console.WriteLine($"\nThere is a total of {combinationOfMatches} different combinations for {numberOfMatches} matches");
                Console.WriteLine("\n");


                Reducerat();
            }
        }

        static void Stryktips(int length, StryktipsWin[] matchWin)
        {
            if(length > 0)
            {
                StryktipsWin[] temp = matchWin;
                int currentLocation = matchWin.Length - length;

                temp[currentLocation] = StryktipsWin.One;
                Stryktips(length - 1, temp);

                temp[currentLocation] = StryktipsWin.X;
                Stryktips(length - 1, temp);

                temp[currentLocation] = StryktipsWin.Two;
                Stryktips(length - 1, temp);
            }
            else
            {
                string s = GetStryktipsString(matchWin[0]);

                for (int i = 1; i < matchWin.Length; i++)
                {
                    s += $", {GetStryktipsString(matchWin[i])}";
                }

                Console.WriteLine(s);
                combinationOfMatches++;
            }
        }

        static void Reducerat()
        {
            StryktipsWin[,] stryktipsReduceratCombinations = new StryktipsWin[4, 81];
            #region Get All Cominations
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 27; j++)
                {
                    stryktipsReduceratCombinations[0, j + (27 * i)] = (StryktipsWin)i;
                }
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    stryktipsReduceratCombinations[1, j + (9 * i)] = (StryktipsWin)(i % 3);
                }
            }

            for (int i = 0; i < 27; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    stryktipsReduceratCombinations[2, j + (3 * i)] = (StryktipsWin)(i % 3);
                }
            }

            for (int i = 0; i < 81; i++)
            {
                stryktipsReduceratCombinations[3, i] = (StryktipsWin)(i % 3);

            }
            #endregion


            for (int i = 0; i < 4; i++)
            {
                string s = "";
                Console.WriteLine();
                for (int j = 0; j < 81; j++)
                {
                    s += GetStryktipsString(stryktipsReduceratCombinations[i, j]);
                }
                Console.WriteLine(s);
            }


            Console.WriteLine("\n\nReducerat:");

            int[] stryktipsReducerat = new int[9];
            for (int i = 0; i < 9; i++)
            {
                while (true)
                {
                    int rndNumber = rnd.Next(81);
                    if (!stryktipsReducerat.Contains(rndNumber))
                    {
                        stryktipsReducerat[i] = rndNumber;
                        break;
                    }
                }
            }

            for (int i = 0; i < 4; i++)
            {
                string s = "";
                for (int j = 0; j < 9; j++)
                {
                    s += GetStryktipsString(stryktipsReduceratCombinations[i, stryktipsReducerat[j]]);
                }
                Console.WriteLine(s);
                Console.WriteLine();
            }
        }


    }
}
