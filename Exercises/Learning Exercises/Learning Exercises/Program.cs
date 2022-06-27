using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Exercises
{
    internal class Program
    {
        static Random rnd = new Random();
        static ConsoleColor currentColor = Console.ForegroundColor;

        static void Main(string[] args)
        {
            bool keepAlive = true;
            int numberOfAssignments = 25;
            while (keepAlive)
            {
                try
                {
                    Console.Write("Enter assignment number\n" +
                        "-1: Exit");
                    for (int i = 1; i <= numberOfAssignments; i++)
                    {
                        Console.Write($"\n{i}: Exercise {i}");
                    }
                    Console.WriteLine();

                    int assignmentChoice = int.Parse(Console.ReadLine() ?? "");
                    //ConsoleColor currentColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Green;

                    switch (assignmentChoice)
                    {
                        case 1:
                            WriteRunExercise(1);
                            RunExerciseOne();
                            break;

                        case 2:
                            WriteRunExercise(2);
                            RunExerciseTwo();
                            break;

                        case 3:
                            WriteRunExercise(3);
                            RunExerciseThree();
                            break;

                        case 4:
                            WriteRunExercise(4);
                            RunExerciseFour();
                            break;

                        case 5:
                            WriteRunExercise(5);
                            RunExerciseFive();
                            break;

                        case 6:
                            WriteRunExercise(6);
                            RunExerciseSix();
                            break;

                        case 7:
                            WriteRunExercise(7);
                            RunExerciseSeven();
                            break;

                        case 8:
                            WriteRunExercise(8);
                            RunExerciseEight();
                            break;

                        case 9:
                            WriteRunExercise(9);
                            RunExerciseNine();
                            break;

                        case 10:
                            WriteRunExercise(10);
                            RunExerciseTen();
                            break;

                        case 11:
                            WriteRunExercise(11);
                            RunExerciseEleven();
                            break;

                        case 12:
                            WriteRunExercise(12);
                            RunExerciseTwelve();
                            break;

                        case 13:
                            WriteRunExercise(13);
                            RunExerciseThirteen();
                            break;

                        case 14:
                            WriteRunExercise(14);
                            RunExerciseFourteen();
                            break;

                        case 15:
                            WriteRunExercise(15);
                            RunExerciseFifteen();
                            break;

                        case 16:
                            WriteRunExercise(16);
                            RunExerciseSixteen();
                            break;

                        case 17:
                            WriteRunExercise(17);
                            RunExerciseSeventeen();
                            break;

                        case 18:
                            WriteRunExercise(18);
                            RunExerciseEighteen();
                            break;

                        case 19:
                            WriteRunExercise(19);
                            RunExerciseNineteen();
                            break;

                        case 20:
                            WriteRunExercise(20);
                            RunExerciseTwenty();
                            break;

                        case 21:
                            WriteRunExercise(21);
                            RunExerciseTwentyOne();
                            break;

                        case 22:
                            WriteRunExercise(22);
                            RunExerciseTwentyTwo();
                            break;

                        case 23:
                            WriteRunExercise(23);
                            RunExerciseTwentyThree();
                            break;

                        case 24:
                            WriteRunExercise(24);
                            RunExerciseTwentyFour();
                            break;

                        case 25:
                            WriteRunExercise(25);
                            RunExerciseTwentyFive();
                            break;

                        case -1:
                            Console.ResetColor();
                            keepAlive = false;
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid assignment number!");
                            Console.ForegroundColor = currentColor;
                            break;
                    }

                    //Console.ResetColor();
                    Console.WriteLine("Hit any key to continue!");
                    Console.ReadKey();
                    Console.Clear();
                }

                catch
                {
                    //ConsoleColor currentColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid assignment number!");
                    Console.ForegroundColor = currentColor;
                }
            }
        }

        private static void WriteRunExercise(int exercise)
        {
            Console.WriteLine($"Running exercise {exercise}");
            Console.ForegroundColor = currentColor;
        }

        private static void RunExerciseOne()
        {
            string nameFirst = "Robin";
            string nameLast = "Sollfors";

            Console.WriteLine($"Hello {nameFirst} {nameLast}! I'm glad to inform you that you are the test subject of my very first assignment!");
        }

        private static void RunExerciseTwo()
        {
            DateTime dateYesterday = DateTime.Today.AddDays(-1);
            DateTime dateToday = DateTime.Today;
            DateTime dateTomorrow = DateTime.Today.AddDays(1);

            Console.WriteLine($"Todays date is {dateToday.ToString("yyyy-MM-dd")}\n" +
                $"Tomorrows date is {dateTomorrow.ToString("yyyy-MM-dd")}\n" +
                $"Yesterdays was {dateYesterday.ToString("yyyy-MM-dd")}");
        }

        private static void RunExerciseThree()
        {
            Console.Write("Enter your first name: ");
            string nameFirst = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string nameLast = Console.ReadLine();

            Console.WriteLine($"Hello {nameFirst} {nameLast}!");
        }

        private static void RunExerciseFour()
        {
            string str = "The quick fox Jumped Over the DOG";
            string restoredString = str;
            restoredString = restoredString.Replace("quick", "brown");
            //restoredString = restoredString.Remove(4, 5);
            int tempIndex = restoredString.IndexOf('J');
            restoredString = restoredString.Remove(tempIndex, 1);
            restoredString = restoredString.Insert(tempIndex, "j");
            tempIndex = restoredString.IndexOf('O');
            restoredString = restoredString.Remove(tempIndex, 1);
            restoredString = restoredString.Insert(tempIndex, "o");
            tempIndex = restoredString.IndexOf('D');
            string tempString = "lazy ";
            tempString += restoredString.Substring(tempIndex, 3).ToLower();
            restoredString += tempString;
            restoredString = restoredString.Remove(tempIndex, 3);

            //ConsoleColor currentColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(str);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(restoredString);
            Console.ForegroundColor = currentColor;
        }

        private static void RunExerciseFive()
        {
            string str = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";
            int startIndex = str.IndexOf("[");
            string arrayStr = str.Substring(startIndex);
            arrayStr = arrayStr.Remove(arrayStr.IndexOf("2"), 4);
            arrayStr = arrayStr.Insert(arrayStr.IndexOf("5") + 1, ",6,7,8,9,10");

            //ConsoleColor currentColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(str);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(arrayStr);
            Console.ForegroundColor = currentColor;
        }

        private static void RunExerciseSix()
        {
            //int a = 8;
            //int b = 1;
            //double average = (double)(a + b) / 2;
            //Console.WriteLine(average);

            bool valid = false;
            int value1 = 0;
            int value2 = 0;

            while (!valid)
            {
                Console.WriteLine("Please input the first integer");
                string v = Console.ReadLine();
                if (int.TryParse(v, out value1))
                {
                    valid = true;
                }
            }
            valid = false;

            while (!valid)
            {
                Console.WriteLine("Please input the second integer");
                string v = Console.ReadLine();
                if (int.TryParse(v, out value2))
                {
                    valid = true;
                }
            }

            bool isValue1Largest = value1 >= value2;
            Console.WriteLine("The integer with the biggest value is: {0}", isValue1Largest ? value1 : value2);
            Console.WriteLine("The integer with the smallest value is: {0}", !isValue1Largest ? value1 : value2);

            Console.WriteLine("The difference between the integers are: {0}", value1 - value2);
            Console.WriteLine("The sum of the integers are: {0}", value1 + value2);
            Console.WriteLine("The product between the integers are: {0}", value1 * value2);
            if (value2 != 0)
            {
                Console.WriteLine("The product between the values are: {0}", value1 / value2);
            }
            else
            {
                Console.WriteLine("You can not divide by 0!");
            }
        }

        static void RunExerciseSeven()
        {
            double radius = 0;
            bool valid = false;
            while (!valid)
            {
                Console.WriteLine("Please input the radius: ");
                string v = Console.ReadLine();
                if (double.TryParse(v, out radius))
                {
                    valid = true;
                }
                if (radius <= 0)
                {
                    //ConsoleColor currentColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("A radius can't be zero or less than zero");
                    Console.ForegroundColor = currentColor;
                    valid = false;
                }
            }

            double area = 2 * Math.PI * radius * radius;
            double volume = (4 * Math.PI * radius * radius * radius) / 3;

            Console.WriteLine($"The area of a circle is: {area}");
            Console.WriteLine($"The volume of a sphere is: {volume}");
        }

        static void RunExerciseEight()
        {
            bool valid = false;
            double value = 0;
            while (!valid)
            {
                Console.WriteLine("Please input the decimal number: ");
                string v = Console.ReadLine();
                if (double.TryParse(v, out value))
                {
                    valid = true;
                }
            }

            string square = value >= 0 ? Math.Sqrt(value).ToString() : Math.Sqrt(-value).ToString() + "i";  // imaginary number?
            double pow2 = value * value;
            double pow10 = value * value * value * value * value * value * value * value * value * value;   // alt, use Math.Pow(value, 10)

            Console.WriteLine($"The square root of {value} is: {square}");
            Console.WriteLine($"{value} to the power of 2 is: {pow2}");
            Console.WriteLine($"{value} to the power of 10 is: {pow10}");
        }

        #region Exercise 9
        static void RunExerciseNine()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine($"Hello {name}!");
            DateTime dateOfBirth = new DateTime(); ;
            bool valid = false;
            while (valid == false)
            {
                Console.WriteLine("When were you born? yyyy/mm/dd");
                string v = Console.ReadLine();
                if (DateTime.TryParse(v, out dateOfBirth))
                {
                    valid = true;
                }
            }


            int age = DateTime.Now.Year - dateOfBirth.Year;
            // If they have not had their birthday yet this year
            if (dateOfBirth.Month > DateTime.Now.Month)
            {
                age--;
            }
            else if (dateOfBirth.Month == DateTime.Now.Month
                && dateOfBirth.Day > DateTime.Now.Day)
            {
                age--;
            }

            if (age >= 18)
            {
                bool orderedBeer = Order("beer");
                if (!orderedBeer)
                {
                    OrderCoke();
                }
            }

            else
            {
                OrderCoke();
            }
        }

        static bool Order(string thingToOrder)
        {
            Console.WriteLine($"Do you want to order a {thingToOrder}? yes or no");
            bool valid = false;
            bool order = false;
            while (valid == false)
            {
                string s = Console.ReadLine();
                if (s == "yes")
                {
                    order = true;
                    Console.WriteLine($"Your {thingToOrder} has been served!");
                    valid = true;
                }
                else if (s == "no")
                {
                    order = false;
                    valid = true;
                }
            }
            return order;
        }

        static void OrderCoke()
        {
            string cokeStr = "coke";
            bool order = Order(cokeStr);
            if (!order)
            {
                Console.WriteLine($"No other other options are available at this time");
            }
        }
        #endregion

        #region Exercise 10
        static void RunExerciseTen()
        {
            Console.Write("Enter assignment number\n" +
                        "-1: Exit\n" +
                        "1: Division between a & b\n" +
                        "2: Exercise 4\n" +
                        "3: Change forground color");

            Console.WriteLine();

            int optionChoice = int.Parse(Console.ReadLine() ?? "");

            switch (optionChoice)
            {
                case 1:
                    ExerciseTenDivide();
                    break;

                case 2:
                    RunExerciseFour();
                    break;

                case 3:
                    ExerciseTenChangeColor();
                    break;

                case -1:
                    break;

                default:
                    //ConsoleColor currentColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid option number!");
                    Console.ForegroundColor = currentColor;
                    break;
            }
        }

        static void ExerciseTenDivide()
        {
            Console.WriteLine();
            double a = 0;
            double b = 0;
            bool valid = false;
            while (!valid)
            {
                Console.WriteLine("Please input the value a:");
                string v = Console.ReadLine();
                if (double.TryParse(v, out a))
                {
                    valid = true;
                }
            }

            valid = false;
            while (!valid)
            {
                Console.WriteLine("Please input the value b:");
                string v = Console.ReadLine();
                if (double.TryParse(v, out b))
                {
                    valid = true;

                    if (b == 0)
                    {
                        valid = false;
                        Console.WriteLine("You can't divide by 0");
                    }
                }
            }

            Console.WriteLine($"a / b = {a / b}");
        }

        static bool changedColor = false;
        static void ExerciseTenChangeColor()
        {
            if (!changedColor)
            {
                Console.ForegroundColor = RandomColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            changedColor = !changedColor;
            currentColor = Console.ForegroundColor;
            Console.WriteLine("Current color:");
        }

        static ConsoleColor RandomColor()
        {
            ConsoleColor rndColor = ConsoleColor.Gray;
            bool notBlackOrGray = false;
            while (!notBlackOrGray)
            {
                var consoleColors = Enum.GetValues(typeof(ConsoleColor));
                rndColor = (ConsoleColor)consoleColors.GetValue(rnd.Next(consoleColors.Length));
                if (rndColor != ConsoleColor.Black && rndColor != ConsoleColor.Gray) { notBlackOrGray = true; }
            }

            return rndColor;
        }
        #endregion

        #region Exercise 11
        static void RunExerciseEleven()
        {
            Console.WriteLine("Please input an int above 0");
            int value = -1;
            int.TryParse(Console.ReadLine() ?? "", out value);
            if (value > 0)
            {
                Console.WriteLine();
                for (int i = 0; i <= value; i++)
                {
                    ExerciseElevenPrintEvenOrOdd(i);
                }
                Console.WriteLine("-------------------------------------");
                for (int i = value; i >= 0; i--)
                {
                    ExerciseElevenPrintEvenOrOdd(i);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Value not valid");
            }

            Console.ForegroundColor = currentColor;
        }

        static void ExerciseElevenPrintEvenOrOdd (int value)
        {
            if(value % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            Console.WriteLine(value);
        }
        #endregion

        static void RunExerciseTwelve()
        {
            Console.WriteLine("\n");
            for (int i = 1; i < 11; i++)
            {
                string s = "";
                for (int j = 1; j < 11; j++)
                {
                    s += (i * j).ToString() + "\t";
                }
                Console.WriteLine(s);
                Console.WriteLine("\n");
            }
        }

        static void RunExerciseThirteen()
        {
            int maxNumGenerated = 2;
            int randomNum = rnd.Next(maxNumGenerated) + 1;

            Console.WriteLine($"Random number generated between 1 and {maxNumGenerated}, please guess the number." +
            "\nYou can exit/giveup by typing \"0\"");
            bool numberFound = false, valid = false;
            int guessedNumber = 0, numberOfGuesses = 0;

            while (!numberFound)
            {
                while (!valid)
                {
                    valid = int.TryParse(Console.ReadLine(), out guessedNumber);
                    if (!valid)
                    {
                        Console.WriteLine("Invalid value, please input a valid value");
                    }

                    else if (guessedNumber < 0 || guessedNumber > maxNumGenerated)
                    {
                        Console.WriteLine("Please input a value between 0 and 100");
                        valid = false;
                    }
                }

                valid = false;
                numberOfGuesses++;

                if (guessedNumber == randomNum)
                {
                    Console.WriteLine("Congratulations, you found the number " + randomNum.ToString() + ", and it took you this amount of tries: " + numberOfGuesses.ToString());
                    numberFound = true;
                }

                else if (guessedNumber == 0)
                {
                    Console.WriteLine("You gave up after " + (numberOfGuesses - 1).ToString() + " number of tries, better luck next time." +
                        "\nExiting function");
                    numberFound = true;
                }

                else if (guessedNumber > randomNum)
                {
                    Console.WriteLine("Your guess was too big");
                }

                else if (guessedNumber < randomNum)
                {
                    Console.WriteLine("Your guess was too small");
                }
            }
        }

        static void RunExerciseFourteen()
        {
            Console.WriteLine("Please enter a positive int. type -1 to exit");
            List<int> intList = new List<int>();

            bool running = true;
            bool valid = false;
            while (running)
            {
                valid = false;
                while (!valid)
                {
                    Console.Write("Enter a number: ");
                    int num = 0;
                    string s = Console.ReadLine();
                    if(int.TryParse(s, out num))
                    {
                        if(num >= 0)
                        {
                            intList.Add(num);
                            valid = true;
                        }
                        else if (num == -1)
                        {
                            valid = true;
                            running = false;
                        }
                        else
                        {
                            valid=false;
                            Console.WriteLine($"{num} is not positive!");
                        }
                    }

                }
            }

            int sum = 0;
            for(int i = 0; i < intList.Count; i++)
            {
                sum += intList[i];
            }
            double average = (double)sum / intList.Count;
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");
        }

        #region Exercise 15
        static void RunExerciseFifteen()
        {
            Console.WriteLine(
                "Addition" +
                "0: Return\n" +
                "1: x is dividable with y[] and is it perfect\n" +
                "2: Find first x number of perfect numbers\n");

            string line = Console.ReadLine();
            int additionNumber;
            if (int.TryParse(line, out additionNumber))
            {
                switch (additionNumber)
                {
                    case 0:
                        return;

                    case 1:
                        ExersizeFifteenDividable();
                        break;

                    case 2:
                        ExersizeFifteenPerfectNumbers();
                        break;

                    default:
                        Console.WriteLine("Not a valid value, please try again");
                        break;
                }

            }
        }

        static void ExersizeFifteenDividable()
        {
            bool valid = false;
            int value = 0;
            while (!valid)
            {
                Console.Write("Please enter a positive int: ");
                string s = Console.ReadLine();
                valid = int.TryParse(s, out value);
                if (!valid || value < 1)
                {
                    Console.WriteLine("Invalid input");
                    valid = false;
                }
            }

            List<int> dividableList = ExersizeFifteenDividableBy(value);
            string dividableStr = dividableList[0].ToString();
            for (int i = 1; i < dividableList.Count; i++)
            {
                dividableStr += $", {dividableList[i]}";
            }

            Console.WriteLine($"{value} is dividble with: {dividableStr}\n" +
                $"Is {value} a perfect number? {ExersizeFifteenIsPerfectNumber(value, dividableList)}");
        }

        static List<int> ExersizeFifteenDividableBy(int a)
        {
            List<int> dividableList = new List<int>();
            for(int i = 1; i <= a/2; i++)
            {
                if(a % i == 0)
                {
                    dividableList.Add(i);
                }
            }

            return dividableList;
        }

        static bool ExersizeFifteenIsPerfectNumber(int number, List<int> dividableList)
        {
            int sum = 0;
            for(int i = 0; i < dividableList.Count; i++)
            {
                sum += dividableList[i];
            }

            if(number == sum)
            {
                return true;
            }
            return false;
        }

        static void ExersizeFifteenPerfectNumbers()
        {
            bool valid = false;
            int value = 0;
            while (!valid)
            {
                // Perfect number 5 is 33 550 336, and that takes too long to find (number 6 is 8 589 869 056)
                Console.Write("Please enter a positive int to find the first x number of perfect numbers (Max 4): ");
                string s = Console.ReadLine();
                valid = int.TryParse(s, out value);
                if (!valid || value < 1 || value > 4)
                {
                    Console.WriteLine("Invalid input");
                    valid = false;
                }
            }

            ExersizeFifteenPerfectNumbersFind(value);
        }

        static void ExersizeFifteenPerfectNumbersFind(int numberOfPerfectNumbers)
        {
            Console.WriteLine();
            int perfectNumbersFound = 0;
            for (int i = 2; perfectNumbersFound < numberOfPerfectNumbers; i++)
            {
                List<int> dividableList = ExersizeFifteenDividableBy(i);
                bool isPerfect = ExersizeFifteenIsPerfectNumber(i, dividableList);
                if (isPerfect)
                {
                    Console.WriteLine($"{perfectNumbersFound + 1}: {i} is a perfect number and is dividable with");
                    Console.Write($"{dividableList[0]}");
                    for (int j = 1; j < dividableList.Count(); j++)
                    {
                        Console.Write($", {dividableList[j]}");
                    }
                    Console.WriteLine();
                    Console.WriteLine();

                    perfectNumbersFound++;
                }
            }
        }

        #endregion

        static void RunExerciseSixteen()
        {
            Console.WriteLine("How far do you want to calculate Fibonacci?");
            bool valid = false;
            int NumberFibonacci = 0;
            while (!valid)
            {
                Console.Write("Please enter a positive int: ");
                string s = Console.ReadLine();
                valid = int.TryParse(s, out NumberFibonacci);
                if (!valid || NumberFibonacci < 1)
                {
                    Console.WriteLine("Invalid input");
                    valid = false;
                }
            }

            Console.WriteLine();
            int numberCurrent = 1;
            int numberLast = 0;
            Console.Write("0");
            if(NumberFibonacci > 1)
            {
                Console.Write(", 1");
            }
            for (int i = 2; i < NumberFibonacci; i++)
            {
                int nextNumber = numberCurrent + numberLast;
                numberLast = numberCurrent;
                numberCurrent = nextNumber;
                Console.Write($", {nextNumber}");
            }

            Console.WriteLine();
        }

        static void RunExerciseSeventeen()
        {
            Console.Write("Enter a word to check if it's a palindrome: ");
            string s = Console.ReadLine();
            string str = s.ToLower();
            str = str.Replace(" ", "");
            str = str.Replace("-", "");

            bool palindrom = true;
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                {
                    palindrom = false;
                    break;
                }
            }

            Console.WriteLine("\"{0}\" is{1} a palindrom", s, palindrom ? "" : " not");
        }

        static void RunExerciseEighteen()
        {
            int arraySize = 10;
            int[] intArray = new int[arraySize];
            for(int i = 0; i < arraySize; i++)
            {
                intArray[i] = rnd.Next(100) + 1;
            }

            double[] doubleArray = new double[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                doubleArray[i] = 1d / (double)intArray[i];
            }

            for(int i = 0; i < arraySize; i++)
            {
                Console.WriteLine($"{i}: \t" +
                    $"int: {intArray[i]}\t" +
                    $"double: {doubleArray[i]}");
            }
        }

        static void RunExerciseNineteen()
        {
            bool valid = false;
            int payPrice = 0;
            while (!valid)
            {
                Console.Write("Money to play: ");
                string s = Console.ReadLine();
                valid = int.TryParse(s, out payPrice);
                if (!valid || payPrice < 1)
                {
                    Console.WriteLine("Invalid input");
                    valid = false;
                }
            }

            int paySum = 0;
            valid = false;
            while (!valid)
            {
                Console.Write("Money to play: ");
                string s = Console.ReadLine();
                valid = int.TryParse(s, out paySum);
                if (!valid || paySum < 1)
                {
                    Console.WriteLine("Invalid input");
                    valid = false;
                }

                if (paySum < payPrice)
                {
                    Console.WriteLine("Not enough money to pay");
                    valid = false;
                }
            }

            int payChangeBack = paySum - payPrice;
            Console.WriteLine($"Change back = {payChangeBack}");
            Console.WriteLine();
            Console.WriteLine("Coin distribution");

            int[] coinArray = { 1000, 500, 100, 50, 20, 10, 5, 2, 1 };

            int payChangeRemaining = payChangeBack;
            for (int i = 0; i < coinArray.Length; i++)
            {
                int coinNumber = payChangeRemaining / coinArray[i];
                Console.WriteLine($"{coinArray[i]} coins = {coinNumber}");
                payChangeRemaining -= coinNumber * coinArray[i];
            }
        }

        static void RunExerciseTwenty()
        {
            int arraySize = 10;
            int[] intArrayOne = new int[arraySize];
            int[] intArrayTwo = new int[arraySize];
            int[] intArrayThree = new int[arraySize];

            int randomMax = 100;
            for (int i = 0; i < arraySize; i++)
            {
                intArrayOne[i] = rnd.Next(randomMax);
            }

            // Alternativly, you can also use one for loop and use something like quicksort
            int arrayFillingCurrently = 0;
            for (int i = 0; i < arraySize; i++)
            {
                if (intArrayOne[i] % 2 == 1)
                {
                    intArrayTwo[arrayFillingCurrently] = intArrayOne[i];
                    arrayFillingCurrently++;
                }
            }

            for (int i = 0; i < arraySize && arrayFillingCurrently < arraySize; i++)
            {
                if (intArrayOne[i] % 2 == 0)
                {
                    intArrayTwo[arrayFillingCurrently] = intArrayOne[i];
                    arrayFillingCurrently++;
                }
            }

            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write($"{intArrayOne[i]} ");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write($"{intArrayTwo[i]} ");
            }

            //The offsets can later, if you want to, be used to sort the even and odd numbers
            int offsetOdd = 0;
            int offsetEven = arraySize - 1;
            for (int i = 0; i < arraySize || offsetOdd < offsetEven; i++)
            {
                if (intArrayOne[i] % 2 == 1)
                {
                    intArrayThree[offsetOdd] = intArrayOne[i];
                    offsetOdd++;
                }
                else // (intArrayOne[i] % 2 == 0)
                {
                    intArrayThree[offsetEven] = intArrayOne[i];
                    offsetEven--;
                }
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write($"{intArrayThree[i]} ");
            }

            int[] intArrayThreeSorted = intArrayThree;

            for (int i = 0; i < offsetOdd; i++)
            {
                for (int j = 0; j < offsetOdd - 1; j++)
                {
                    //Console.WriteLine($"{intArrayThreeSorted[i]} > {intArrayThreeSorted[i + 1]}");
                    if (intArrayThreeSorted[j] > intArrayThreeSorted[j + 1])
                    {
                        //Console.WriteLine("true");
                        int temp = intArrayThreeSorted[j];
                        intArrayThreeSorted[j] = intArrayThreeSorted[j + 1];
                        intArrayThreeSorted[j + 1] = temp;
                    }
                }
            }

            for (int i = arraySize - 1; i > offsetEven; i--)
            {
                for (int j = arraySize - 1; j > offsetEven + 1; j--)
                {
                    if (intArrayThreeSorted[j] < intArrayThreeSorted[j - 1])
                    {
                        int temp = intArrayThreeSorted[j];
                        intArrayThreeSorted[j] = intArrayThreeSorted[j - 1];
                        intArrayThreeSorted[j - 1] = temp;
                    }
                }
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write($"{intArrayThreeSorted[i]} ");
            }



            Console.ForegroundColor = currentColor;
        }

        static void RunExerciseTwentyOne()
        {
            Console.WriteLine("Please enter values seperated by a \",\"");

            int[] numbers = new int[1];
            bool valid = false;
            while (!valid)
            {
                string[] s = Console.ReadLine().Split(',');
                numbers = new int[s.Length];

                for (int i = 0; i < s.Length; i++)
                {
                    valid = int.TryParse(s[i], out numbers[i]);
                    if (!valid)
                    {
                        Console.WriteLine("Invalid value, please input valid values (wrong value at: {0})", i + 1);
                        break;
                    }
                }
            }

            int valueMin, valueMax;
            double valueAverage = 0;
            valueAverage = valueMin = valueMax = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                valueAverage += numbers[i];

                if(valueMin > numbers[i])
                {
                    valueMin = numbers[i];
                }

                if (valueMax < numbers[i])
                {
                    valueMax = numbers[i];
                }
            }
            valueAverage /= numbers.Length;

            Console.WriteLine($"Min: {valueMin}");
            Console.WriteLine($"Max: {valueMax}");
            Console.WriteLine($"Average: {valueAverage}");
        }

        static void RunExerciseTwentyTwo()
        {

        }

        static void RunExerciseTwentyThree()
        {

        }

        static void RunExerciseTwentyFour()
        {

        }

        static void RunExerciseTwentyFive()
        {

        }
    }
}
