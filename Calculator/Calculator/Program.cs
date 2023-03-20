﻿using System;

namespace Calculator
{
    class Program
    {

        static void Main(string[] args)
        {
            bool endApp = false;

            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {

                // Declare variables and set to empty.
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                // Ask the user to type the first number.
                Console.Write("Type a number, and then press Enter: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("This is not valid input. Please enter an value: ");
                    numInput1 = Console.ReadLine();
                }

                // Ask the user to type the second number.
                Console.Write("Type another number, and then press Enter: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("This is not valid input. Please enter an value: ");
                    numInput2 = Console.ReadLine();
                }


                // Ask the user to choose an operator.
                Console.WriteLine("Choose an operator from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("Your option? ");

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); // Friendly linespacing.

            }

        }
    }

    class Calculator
    {
        public static double DoOperation(double num1, double num2)
        {
            string op = Console.ReadLine();
            double result = double.NaN; // Default value is "not-a-number" which we use if an operation, such as division, could result in an error

            // Use a switch statement to do the math.
            while (true) {
                if (String.Equals(op, "a", StringComparison.OrdinalIgnoreCase))
                {
                    result = num1 + num2;
                    break;
                }else if (String.Equals(op, "s", StringComparison.OrdinalIgnoreCase))
                {
                    result = num1 + num2;
                    break;
                }
                else if (String.Equals(op, "m", StringComparison.OrdinalIgnoreCase))
                {
                    result = num1 + num2;
                    break;
                }
                else if (String.Equals(op, "d", StringComparison.OrdinalIgnoreCase))
                {
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                }
                else
                {
                    Console.Write($"Operation {op} not found");
                    Console.Write("This is not valid input. Please enter (A/S/M/D) : ");
                    op = Console.ReadLine();
                }
            }


            return result;
        }
    }
}
