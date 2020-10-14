using System;

namespace Lab6PowersTable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runProgram = true;

            while (runProgram)
            {
                Console.Write("Please enter an integer value: ");
                int inputNumber;

                while (!int.TryParse(Console.ReadLine(), out inputNumber))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Invalid input!");
                    Console.ResetColor();
                    Console.Write("\nPlease enter an integer value: ");
                }

                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine($"Your number: {inputNumber}");
                Console.WriteLine("");
                Console.WriteLine("Number" + "\t" + "Square" + "\t" + "Cube");
                Console.WriteLine("=====" + "\t" + "=====" + "\t" + "=====");

                PowerTable(inputNumber);

                Console.Write("\nWould you like to enter another number (y / n)? ");

                bool yesNoValid = false;

                while (yesNoValid == false)
                {
                    string yesNo = Console.ReadLine().ToLower();

                    if (yesNo == "y")
                    {
                        Console.Clear();
                        yesNoValid = true;
                    }
                    else if (yesNo == "n")
                    {
                        Console.Clear();
                        Console.Beep();
                        Console.WriteLine("Thank you! Have a great day :)");
                        yesNoValid = true;
                        runProgram = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input!");
                        Console.ResetColor();
                        Console.Write("\nWould you like to enter another number (y / n) ? ");
                    }
                }

            }

        }

        public static void PowerTable(int inputNumber)
        {
            int displayNumber = 0;

            for (int i = 1; i <= inputNumber; i++)
            {
                displayNumber += 1;
                int square = displayNumber * displayNumber;
                int cube = displayNumber * displayNumber * displayNumber;
                Console.WriteLine(displayNumber + "\t" + square + "\t" + cube);

            }

        }

    }
}
