using System;

namespace myCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables 
            string Operand;
            double num1;
            double num2;
            string playAgain = "Y";

            Console.WriteLine("______ Console Calculator in C# _______");
            Console.WriteLine();
            // Big while loop, executes when user enters - "Y" or "y".
            while (playAgain == "Y" || playAgain == "y")
            {
                // Console asks user for a number.
                Console.Write("Type in a number, then press Enter: ");

                // Checks user input, converts string representation to double number equivalent, returns either true/false, if false while loop executes. 
                while (Double.TryParse(Console.ReadLine(), out num1) == false)
                {
                    Console.Clear();
                    Console.Write("Invlaid Input! Type in a number, then press Enter: ");
                }
                Console.Clear();

                // Asks user for math operation type.
                Console.WriteLine("Select from the following list: \n");
                Console.WriteLine("Multiplication: * \n");
                Console.WriteLine("Division: / \n");
                Console.WriteLine("Nodulo: * \n");
                Console.WriteLine("Addition: + \n");
                Console.WriteLine("Subtraction: - \n");
                Operand = Convert.ToString(Console.ReadLine());

                // Checks if user input matches math operand, if false while loop executes
                while (!Operand.Equals("*") && !Operand.Equals("/") && !Operand.Equals("%") && !Operand.Equals("+") && !Operand.Equals("-"))
                {
                    Console.Clear();
                    Console.WriteLine("Invalid Input! Select from the following list: \n");
                    Console.WriteLine("Multiplication: * \n");
                    Console.WriteLine("Division: / \n");
                    Console.WriteLine("Nodulo: * \n");
                    Console.WriteLine("Addition: + \n");
                    Console.WriteLine("Subtraction: - \n");
                    Operand = Convert.ToString(Console.ReadLine());
                }
                Console.Clear();

                // Asks user for number.
                Console.Write("Type in a number, then press Enter: ");

                // Checks user input, converts string representation to double number equivalent, returns either true/false, if false while loop executes. 
                while (Double.TryParse(Console.ReadLine(), out num2) == false)
                {
                    Console.Clear();
                    Console.Write("Invlaid Input! Type in a number, then press Enter: ");
                }
                Console.Clear();

                // Checks for user input 0 - division operand. If true while loop executes. 
                while (num2 == 0)
                {
                    Console.Clear();
                    Console.Write("Enter a non-zero divisor: ");

                    // Nested while loop - if user enters a non-numerical input after the non-zero divisor.
                    while (Double.TryParse(Console.ReadLine(), out num2) == false)
                    {
                        Console.Clear();
                        Console.Write("Invlaid Input! Type in a number, then press Enter: ");
                    }
                    Console.Clear();
                }
                // Use switch statement to do the math.
                switch (Operand)
                {
                    case "*":
                        double multiply = num1 * num1;
                        Console.WriteLine("Answer: " + multiply);
                        Console.WriteLine();
                        break;
                    case "/":
                        double division = num1 / num2;
                        division = Math.Round(division, 2);
                        Console.WriteLine("Answer: " + division);
                        Console.WriteLine();
                        break;
                    case "%":
                        double mod = num1 % num2;
                        Console.WriteLine("Answer: " + mod);
                        Console.WriteLine();
                        break;
                    case "+":
                        double add = num1 + num2;
                        Console.WriteLine("Answer: " + add);
                        Console.WriteLine();
                        break;
                    case "-":
                        double subtract = num1 - num2;
                        Console.WriteLine("Answer: " + subtract);
                        Console.WriteLine();
                        break;
                }
                // Asking the user if they want to perform another calculation.
                Console.Write("------ To perform another calculation, Type 'Y', then press Enter. To Finish, Enter any key: ");
                playAgain = Console.ReadLine();
                Console.Clear();
            }
            Console.Write("------ End of application! ------");
        }
    }
}