using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Assignment1
    {
        public static void Calculator()
        {
            Console.WriteLine("Welcome to the calculator!\n");

            while (true)
            {
                Console.WriteLine(
                    "0: Exit\n" +
                    "1: Addition\n" +
                    "2: Subtraction\n" +
                    "3: Multiply\n" +
                    "4: Division\n" +
                    "5: Power of\n" +
                    "6: Free write");

                string line = Console.ReadLine();
                int functionNumber;
                if (int.TryParse(line, out functionNumber))
                {
                    bool repeat = true;
                    while (repeat)
                    {
                        switch (functionNumber)
                        {
                            case 0:
                                Console.Clear();
                                return;

                            case 1:
                                Addition();
                                break;

                            case 2:
                                Subtraction();
                                break;

                            case 3:
                                Multiplication();
                                break;

                            case 4:
                                Division();
                                break;

                            case 5:
                                PowerOf();
                                break;

                            case 6:
                                FreeWrite();
                                break;

                            default:
                                Console.WriteLine("No calculator function for this int, please try again");
                                repeat = false;
                                break;
                        }

                        if (repeat == true)
                        {
                            Console.WriteLine("\nRepeat function? \"0\" for no, \"1\" for yes");
                            line = Console.ReadLine();
                            if (line == "1")
                            {
                                repeat = true;
                                Console.WriteLine("\n");
                            }
                            else if (line == "0")
                            {
                                repeat = false;
                                Console.WriteLine("\n");
                            }

                            else
                            {
                                repeat = false;
                                Console.WriteLine("Not a valid input, function not repeating");
                                Console.WriteLine("\n");
                            }
                        }
                    }

                }

                else { Console.WriteLine("Please input an int"); }
            }
        }

        #region Addition
        static void Addition()
        {
            Console.WriteLine(
                "Addition" +
                "0: Return\n" +
                "1: Addition of two numbers\n" +
                "2: Addition of multiple numbers\n");

            string line = Console.ReadLine();
            int additionNumber;
            if (int.TryParse(line, out additionNumber))
            {
                switch (additionNumber)
                {
                    case 0:
                        return;

                    case 1:
                        AdditionTwo();
                        break;

                    case 2:
                        AdditionMultiple();
                        break;

                    default:
                        Console.WriteLine("Not a valid value, please try again");
                        break;
                }

            }
        }

        static void AdditionTwo()
        {
            double[] numbers = new double[2];
            bool valid = false;
            string s;

            Console.WriteLine("\nPlease enter the first value:");
            while (!valid)
            {
                s = Console.ReadLine();
                valid = double.TryParse(s, out numbers[0]);
                if (!valid)
                {
                    Console.WriteLine("{0} is NOT a valid value, please input a valid value!", s);
                }
            }
            valid = false;
            Console.WriteLine("\nPlease enter the second value to add:");
            while (!valid)
            {
                s = Console.ReadLine();
                valid = double.TryParse(s, out numbers[1]);
                if (!valid)
                {
                    Console.WriteLine("{0} is NOT a valid value, please input a valid value!", s);
                }
            }

            Console.WriteLine("{0} + {1} = {2}", numbers[0], numbers[1], numbers[0] + numbers[1]);
        }

        static void AdditionMultiple()
        {
            Console.WriteLine("Please enter values seperated by a \"+\"");

            double[] numbers = new double[1];
            bool valid = false;
            while (!valid)
            {
                string[] s = Console.ReadLine().Split('+');
                numbers = new double[s.Length];

                for (int i = 0; i < s.Length; i++)
                {
                    valid = double.TryParse(s[i], out numbers[i]);
                    if (!valid)
                    {
                        Console.WriteLine("Invalid value, please input valid values (wrong value at: {0})", i + 1);
                        break;
                    }
                }
            }

            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine("Sum of values: {0}", sum);
        }
        #endregion

        #region Subtraction
        static void Subtraction()
        {
            Console.WriteLine(
                "Subtract" +
                "0: Return\n" +
                "1: Subtraction of two numbers\n" +
                "2: Subtraction of multiple numbers\n");

            string line = Console.ReadLine();
            int subtractionNumber;
            if (int.TryParse(line, out subtractionNumber))
            {
                switch (subtractionNumber)
                {
                    case 0:
                        return;

                    case 1:
                        SubtractionTwo();
                        break;

                    case 2:
                        SubtractionMultiple();
                        break;

                    default:
                        Console.WriteLine("Not a valid value, please try again");
                        break;
                }
            }
        }

        static void SubtractionTwo()
        {
            double[] numbers = new double[2];
            bool valid = false;
            string s;

            Console.WriteLine("\nPlease enter the first value:");
            while (!valid)
            {
                s = Console.ReadLine();
                valid = double.TryParse(s, out numbers[0]);
                if (!valid)
                {
                    Console.WriteLine("{0} is NOT a valid value, please input a valid value!", s);
                }
            }
            valid = false;
            Console.WriteLine("\nPlease enter the second number to subtract:");
            while (!valid)
            {
                s = Console.ReadLine();
                valid = double.TryParse(s, out numbers[1]);
                if (!valid)
                {
                    Console.WriteLine("{0} is NOT a valid value, please input a valid value!", s);
                }
            }

            Console.WriteLine("{0} - {1} = {2}", numbers[0], numbers[1], numbers[0] - numbers[1]);
        }

        static void SubtractionMultiple()
        {
            Console.WriteLine("Please enter values seperated by a \"-\"");

            double[] numbers = new double[1];
            bool valid = false;
            while (!valid)
            {
                string[] s = Console.ReadLine().Split('-');
                numbers = new double[s.Length];

                for (int i = 0; i < s.Length; i++)
                {
                    valid = double.TryParse(s[i], out numbers[i]);
                    if (!valid)
                    {
                        Console.WriteLine("Invalid value, please input valid values (wrong value at: {0})", i + 1);
                        break;
                    }
                }
            }

            double sub = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                sub -= numbers[i];
            }

            Console.WriteLine("Subtraction of values: {0}", sub);
        }
        #endregion

        #region Multiplication
        static void Multiplication()
        {
            Console.WriteLine(
                "Multiply" +
                "0: Return\n" +
                "1: Multiplication of two numbers\n" +
                "2: Multiplication of multiple numbers\n");

            string line = Console.ReadLine();
            int multiplicationNumber;
            if (int.TryParse(line, out multiplicationNumber))
            {
                switch (multiplicationNumber)
                {
                    case 0:
                        return;

                    case 1:
                        MultiplyTwo();
                        break;

                    case 2:
                        MultiplyMultiple();
                        break;

                    default:
                        Console.WriteLine("Not a valid value, please try again");
                        break;
                }
            }
        }
        static void MultiplyTwo()
        {
            double[] numbers = new double[2];
            bool valid = false;
            string s;

            Console.WriteLine("\nPlease enter the first value:");
            while (!valid)
            {
                s = Console.ReadLine();
                valid = double.TryParse(s, out numbers[0]);
                if (!valid)
                {
                    Console.WriteLine("{0} is NOT a valid value, please input a valid value!", s);
                }
            }
            valid = false;
            Console.WriteLine("\nPlease enter the second number to multiply:");
            while (!valid)
            {
                s = Console.ReadLine();
                valid = double.TryParse(s, out numbers[1]);
                if (!valid)
                {
                    Console.WriteLine("{0} is NOT a valid value, please input a valid value!", s);
                }
            }

            Console.WriteLine("{0} * {1} = {2}", numbers[0], numbers[1], numbers[0] * numbers[1]);
        }

        static void MultiplyMultiple()
        {
            Console.WriteLine("Please enter values seperated by a \"*\"");

            double[] numbers = new double[1];
            bool valid = false;
            bool multiplyByZero = false;
            while (!valid)
            {
                multiplyByZero = false;
                string[] s = Console.ReadLine().Split('*');
                numbers = new double[s.Length];

                for (int i = 0; i < s.Length; i++)
                {
                    valid = double.TryParse(s[i], out numbers[i]);
                    if (!valid)
                    {
                        Console.WriteLine("Invalid value, please enter valid values (wrong value at: {0})", i + 1);
                        break;
                    }
                    if (numbers[i] == 0)
                    {
                        multiplyByZero = true;
                    }
                }
            }

            double mult = 0;
            if (!multiplyByZero)    //If one of the multiplications are zero the result will be zero, and to lesser the compution power if there are big numbers and a lot of them
            {
                mult = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    mult *= numbers[i];
                }
            }

            Console.WriteLine("Multiplication of values: {0}", mult);
        }
        #endregion

        #region Divide
        static void Division()
        {
            Console.WriteLine(
                "Divide" +
                "0: Return\n" +
                "1: Division of two numbers\n" +
                "2: Division of multiple numbers\n" +
                "3: Dividable (Rest)");

            string line = Console.ReadLine();
            int multiplicationNumber;
            if (int.TryParse(line, out multiplicationNumber))
            {
                switch (multiplicationNumber)
                {
                    case 0:
                        return;

                    case 1:
                        DivideTwo();
                        break;

                    case 2:
                        DivideMultiple();
                        break;

                    case 3:
                        Divideable();
                        break;

                    default:
                        Console.WriteLine("Not a valid value, please try again");
                        break;
                }
            }
        }

        static void DivideTwo()
        {
            double[] numbers = new double[2];
            bool valid = false;
            string s;

            Console.WriteLine("\nPlease enter the first value:");
            while (!valid)
            {
                s = Console.ReadLine();
                valid = double.TryParse(s, out numbers[0]);
                if (!valid)
                {
                    Console.WriteLine("{0} is NOT a valid value, please input a valid value!", s);
                }
            }
            valid = false;
            Console.WriteLine("\nPlease enter the second number to divide:");
            while (!valid)
            {
                s = Console.ReadLine();
                valid = double.TryParse(s, out numbers[1]);
                if (!valid)
                {
                    Console.WriteLine("{0} is NOT a valid value, please input a valid value!", s);
                }
                else if (numbers[1] == 0)
                {
                    valid = false;
                    Console.WriteLine("You can NOT divide by 0!!!!!" +
                        "\n please enter another value");
                }
            }

            Console.WriteLine("{0} / {1} = {2}", numbers[0], numbers[1], numbers[0] / numbers[1]);
        }

        static void DivideMultiple()
        {
            Console.WriteLine("Please enter values seperated by a \"/\"");

            double[] numbers = new double[1];
            bool valid = false;
            while (!valid)
            {
                string[] s = Console.ReadLine().Split('/');
                numbers = new double[s.Length];

                for (int i = 0; i < s.Length; i++)
                {
                    valid = double.TryParse(s[i], out numbers[i]);
                    if (!valid)
                    {
                        Console.WriteLine("Invalid value, please input valid values (wrong value at: {0})", i + 1);
                        break;
                    }
                    else if (numbers[i] == 0 && i > 0)
                    {
                        valid = false;
                        Console.WriteLine("You can NOT divide by 0!!! (0 at: {0})" +
                            "\nPlease input valid values", i + 1);
                        break;
                    }
                }
            }

            bool zeroDivide = numbers[0] == 0;
            double div = 0;
            if (!zeroDivide)    //If one of the multiplications are zero the result will be zero, and to lesser the compution power if there are big numbers and a lot of them
            {
                div = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    div /= numbers[i];
                }
            }

            Console.WriteLine("Division of values: {0}", div);
        }

        static void Divideable()
        {
            double[] numbers = new double[2];
            bool valid = false;
            string s = "";

            Console.WriteLine("\nPlease enter the first value:");
            while (!valid)
            {
                s = Console.ReadLine();
                valid = double.TryParse(s, out numbers[0]);
                if (!valid)
                {
                    Console.WriteLine("{0} is NOT a valid value, please input a valid value!", s);
                }
            }
            valid = false;
            Console.WriteLine("\nPlease enter the second number to divide:");
            while (!valid)
            {
                s = Console.ReadLine();
                valid = double.TryParse(s, out numbers[1]);
                if (!valid)
                {
                    Console.WriteLine("{0} is NOT a valid value, please input a valid value!", s);
                }
                else if (numbers[1] == 0)
                {
                    valid = false;
                    Console.WriteLine("You can NOT divide by 0!!!!!" +
                        "\n please enter another value");
                }
            }

            double rest = numbers[0] % numbers[1];
            if(rest == 0)
            {
                s = string.Format("{0} is dividable with {1}. It divides {2} number of times"
                    , numbers[0], numbers[1], numbers[0] / numbers[1]);
            }
            else
            {
                s = string.Format("{0} is not dividable with {1}. It divides {2} number of times and has a rest of {3}"
                    , numbers[0], numbers[1], (numbers[0] - rest) / numbers[1], rest);
            }
            Console.WriteLine(s);
        }
        #endregion

        #region Powerof
        #region Addition
        static void PowerOf()
        {
            Console.WriteLine(
                "To the power of\n" +
                "0: Return\n" +
                "1: To the power of 2\n" +
                "2: To the power of X\n");

            string line = Console.ReadLine();
            int additionNumber;
            if (int.TryParse(line, out additionNumber))
            {
                switch (additionNumber)
                {
                    case 0:
                        return;

                    case 1:
                        PowerOfTwo();
                        break;

                    case 2:
                        PowerOfX();
                        break;

                    default:
                        Console.WriteLine("Not a valid value, please try again");
                        break;
                }

            }
        }

        static void PowerOfTwo()
        {
            double number = 0;
            bool valid = false;
            string s;

            Console.WriteLine("\nPlease enter the value:");
            while (!valid)
            {
                s = Console.ReadLine();
                valid = double.TryParse(s, out number);
                if (!valid)
                {
                    Console.WriteLine("{0} is NOT a valid value, please input a valid value!", s);
                }
            }

            Console.WriteLine("{0}^2 = {1}",number , number * number);
        }

        static void PowerOfX()
        {
            Console.WriteLine("Please enter the value of the number:");

            double[] numbers = new double[2];
            bool valid = false;
            string s = "";
            while (!valid)
            {
                s = Console.ReadLine();

                valid = double.TryParse(s, out numbers[0]);
                if (!valid)
                {
                    Console.WriteLine("Invalid value, please input a valid value");
                    break;
                }
            }
            valid = false;
            Console.WriteLine("Please enter the power of value to raise {0} to", numbers[0]);
            while (!valid)
            {
                s = Console.ReadLine();

                valid = double.TryParse(s, out numbers[1]);
                if (!valid)
                {
                    Console.WriteLine("Invalid value");
                    break;
                }
            }

            double pow = numbers[0]; //Math.Pow(numbers[0], numbers[1]);
            if(numbers[1] > 0)
            {
                for (int i = 1; i < numbers[1]; i++)
                {
                    pow *= numbers[0];
                }
            }

            else if (numbers[1] < 0)
            {
                if (numbers[0] != 0)
                {
                    for (int i = 0; i > numbers[0]; i--)
                    {
                        pow /= numbers[0];
                    }
                }
                else
                {
                    Console.WriteLine("The first value can't be 0, unless the second value is also 0");
                    return;
                }
            }
            else //numbers[1] == 0
            {
                pow = 1;
            }


            Console.WriteLine("{0}^{1} = {2}", numbers[0], numbers[1], pow);
        }
        #endregion
        #endregion

        #region FreeWrite
        static void FreeWrite()
        {
            Console.WriteLine("\nPlease enter values seperated by a \"+\", \"-\", \"*\" or \"/\"");

            List<double> numbers = new List<double>();  //double[] numbers = new double[1];
            bool valid = false;
            while (!valid)
            {
                string completeText = Console.ReadLine();
                string[] numberString = completeText.Split('+', '-', '*', '/');
                //numbers = new double[numberString.Length];

                for (int i = 0; i < numberString.Length; i++)
                {
                    double value;
                    valid = double.TryParse(numberString[i], out value); //valid = double.TryParse(numberString[i], out numbers[i]);
                    if (!valid)
                    {
                        Console.WriteLine("Invalid value, please input valid values (wrong value at: {0})", i + 1);
                        break;
                    }
                    numbers.Add(value);
                }

                if (valid)
                {
                    string[] operationString = completeText.Split(numberString, StringSplitOptions.RemoveEmptyEntries);
                    int temp = 0;
                    for (int i = 0; i < operationString.Length; i++)
                    {
                        if (operationString[i] == "*" && i + 1 - temp < numbers.Count)
                        {
                            //Console.WriteLine("multiply {0} * {1} = {2}", numbers[i - temp], numbers[i - temp + 1], numbers[i - temp] * numbers[i - temp + 1]);
                            numbers[i - temp] *= numbers[i + 1 - temp];
                            numbers.RemoveAt(i + 1 - temp);
                            temp++;
                        }

                        else if (operationString[i] == "/" && i + 1 - temp < numbers.Count)
                        {
                            if(numbers[i + 1 - temp] == 0)
                            {
                                Console.WriteLine("You can't divide by 0!!!");
                                valid = false;
                                break;
                            }
                            Console.WriteLine("multiply {0} / {1} = {2}", numbers[i - temp], numbers[i - temp + 1], numbers[i - temp] / numbers[i - temp + 1]);
                            numbers[i - temp] /= numbers[i + 1 - temp];
                            numbers.RemoveAt(i + 1 - temp);
                            temp++;
                        }
                    }

                    if (valid)
                    {
                        //temp = 0;
                        for (int i = 0; i < operationString.Length; i++)
                        {
                            if (operationString[i] == "+" && numbers.Count >= 2)
                            {
                                //Console.WriteLine("Add {0} : {1}", numbers[0], numbers[1]);
                                numbers[0] += numbers[1];
                                numbers.RemoveAt(1);
                            }

                            else if (operationString[i] == "-" && numbers.Count >= 2)
                            {
                                numbers[0] -= numbers[1];
                                numbers.RemoveAt(1);
                            }
                        }

                        Console.WriteLine("The sum of all these operations are: {0}", numbers[0]);
                    }



                }

            }
        }
        #endregion
    }
}
