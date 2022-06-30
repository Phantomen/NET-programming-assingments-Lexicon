using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogJump
{
    internal class Program
    {

        static int numberOfJumpsCombinations = 0;
        static void Main(string[] args)
        {
            bool playing = true;
            while (playing)
            {
                bool valid = false;
                while (!valid)
                {
                    int numberOfJumps = 1;
                    try
                    {
                        Console.WriteLine("Please input an int that is larger than 0\n" +
                            "Or enter -1 to exit");
                        numberOfJumps = int.Parse(Console.ReadLine());

                        if(numberOfJumps == -1)
                        {
                            playing = false;
                            break;
                        }
                        else if (numberOfJumps <= 0)
                        {
                            Console.WriteLine("That is not a valid jump distance");
                        }
                        else
                        {
                            valid = true;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("That is not a valid jump distance");
                    }

                    numberOfJumpsCombinations = 0;
                    Console.WriteLine($"\nThis is all the unique way the frog can jump the distance of {numberOfJumps}");
                    FrogJumping(numberOfJumps, "");
                    Console.WriteLine($"\nThere is a total of {numberOfJumpsCombinations} different combinations of jumps for a distance of {numberOfJumps}\n" +
                        "It follows the Fibonacci Sequence + 1");
                    Console.WriteLine("\n");

                }
            }
        }


        static void FrogJumping(int distanceRemaining, string jumpString = "")
        {
            if(distanceRemaining >= 1)
            {
                FrogJumping(distanceRemaining - 1, jumpString == "" ? "1": jumpString + ",1");
            }
            if(distanceRemaining >= 2)
            {
                FrogJumping(distanceRemaining - 2, jumpString == "" ? "2" : jumpString + ",2");
            }

            if(distanceRemaining == 0)
            {
                string[] outputStr = jumpString.Split(',');
                Console.WriteLine($"({jumpString})");
                numberOfJumpsCombinations++;
            }
        }
    }
}
