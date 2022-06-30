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
            One,
            X,
            Two
        }

        static int combinationOfMatches = 0;

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
                #region Get output
                string s = "";
                if (matchWin[0] == StryktipsWin.One)
                {
                    s += "1";
                }
                else if (matchWin[0] == StryktipsWin.X)
                {
                    s += "X";
                }
                else // (matchWin[0] == StryktipsWin.Two)
                {
                    s += "2";
                }
                for (int i = 1; i < matchWin.Length; i++)
                {
                    if(matchWin[i] == StryktipsWin.One)
                    {
                        s += ",1";
                    }
                    else if (matchWin[i] == StryktipsWin.X)
                    {
                        s += ",X";
                    }
                    else // (matchWin[i] == StryktipsWin.Two)
                    {
                        s += ",2";
                    }
                }
                #endregion
                Console.WriteLine(s);
                combinationOfMatches++;
            }
        }
    }
}
