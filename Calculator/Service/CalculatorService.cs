using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Service
{
    public class CalculatorService
    {
        public string[] OptionsList = { "Start", "Options", "Exit" };
        public CalculatorService() { 
       
        }

        public void StartCalc ()
        {
            Console.WriteLine("Hey, let us calculate something! :D");
            Console.WriteLine();
            var Option = CalcMenu();

            Console.Clear();

            if (Option == OptionsList[0])
            {
                CalcProcess();
            }
            else if (Option == OptionsList[1])
            {
                Console.WriteLine("There are no Options Yet!");
                Console.ReadLine();
            }
            else if (Option == OptionsList[2])
            {
                Console.WriteLine("Goodbye Sir!");
            }
            else
            {
                Console.WriteLine("Error: Option not Found!");
            }
        }

        public string CalcMenu ()
        {
            string[] options = OptionsList.ToArray();
            int selectedOptionIndex = 0;

            while (true)
            {
                Console.Clear();

                Console.WriteLine("-------------------------");
                Console.WriteLine("Welcome to my Calculator!");
                Console.WriteLine("Please choose an Option.");
                Console.WriteLine("-------------------------");
                Console.WriteLine();

                for (int i = 0; i < options.Length; i++)
                {
                    if (i == selectedOptionIndex)
                    {
                        Console.Write("-> ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }

                    Console.WriteLine(options[i]);
                }

                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow)
                {
                    selectedOptionIndex = Math.Max(0, selectedOptionIndex - 1);
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    selectedOptionIndex = Math.Min(options.Length - 1, selectedOptionIndex + 1);
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    break;
                }
            }

            Console.Clear();

            return options[selectedOptionIndex];
        }

        public void CalcProcess ()
        {
            Console.WriteLine("What is the first Number you wanna Use?");
            string num1 = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Now which Operator you wann Use?");
            string opr = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Last but not Least which numer should we " + opr + " with?");
            string num2 = Console.ReadLine();

            Console.Clear();

            double result = 0;

            switch (opr)
            {
                case "+":
                    result = Convert.ToDouble(num1) + Convert.ToDouble(num2);
                    break;
                case "-":
                    result = Convert.ToDouble(num1) - Convert.ToDouble(num2);
                    break;
                case "*":
                    result = Convert.ToDouble(num1) * Convert.ToDouble(num2);
                    break;
                case "/":
                    result = Convert.ToDouble(num1) / Convert.ToDouble(num2);
                    break;
                case ":":
                    result = Convert.ToDouble(num1) / Convert.ToDouble(num2);
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }

            Console.WriteLine(num1 + " " + opr + " " + num2 + " = " + result);
            Console.WriteLine("Result: " + result);
            Console.WriteLine();

            bool isValid = false;

            do
            {
                Console.WriteLine("Do you want to proceed? (yes/no)");
                string answer = Console.ReadLine()?.Trim().ToLower();
                Console.Clear();

                if (answer == "yes" || answer == "y")
                {
                    isValid = true;
                    CalcProcess();
                }
                else if (answer == "no" || answer == "n")
                {
                    isValid = true;
                    StopCalc();
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                    isValid = false;
                }
            } while (!isValid);

        }
        public void StopCalc()
        {
            Console.WriteLine("GoodBye");
        }
    }
}
