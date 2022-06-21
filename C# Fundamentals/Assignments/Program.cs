using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(
                    "Please select an assignment!\n" +
                    "0: Exit\n" +
                    "1: Assignment 1 - Calculator\n");

                string line = Console.ReadLine();
                int functionNumber;
                if (int.TryParse(line, out functionNumber))
                {
                    switch (functionNumber)
                    {
                        case 0:
                            return;

                        case 1:
                            Assignment1.Calculator();
                            break;

                        //case 2:


                        default:
                            Console.WriteLine("No function for this int");
                            break;
                    }
                }
                else { Console.WriteLine("No function for this int"); }
            }
        }
    }
}
