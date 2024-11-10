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
                Console.WriteLine("Staring Options!");
                Console.ReadLine();
            }
            else if (Option == OptionsList[2])
            {
                Console.WriteLine("Goodbye Sir!");
                Console.ReadLine();
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
            Console.WriteLine("Choose!");
            Console.ReadLine();
        }
    }
}
