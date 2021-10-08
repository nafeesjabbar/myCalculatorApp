using System;

namespace myCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string Operand;
            double num1;
            double num2;
            string playAgain = "Y";

            Console.WriteLine("------ Basic Calculator ------");

            while (playAgain == "Y" || playAgain == "y")
            {
                Console.Write("Enter First Number: ");

                while (Double.TryParse(Console.ReadLine(), out num1) == false)
                {
                    Console.Clear();
                    Console.Write("Invlaid Input! Please Enter First Number: ");
                }
                Console.Clear();

                Console.Write("Enter Operand: [ * ], [ / ], [ % ], [ + ], [ - ] ");
                Operand = Convert.ToString(Console.ReadLine());

                while (!Operand.Equals("*") && !Operand.Equals("/") && !Operand.Equals("%") && !Operand.Equals("+") && !Operand.Equals("-"))
                {
                    Console.Clear();
                    Console.Write("Invalid Input! Please Enter Operand: [ * ], [ / ], [ % ], [ + ], [ - ] ");
                    Operand = Convert.ToString(Console.ReadLine());
                }
                Console.Clear();

                Console.Write("Enter Second Number: ");

                while (Double.TryParse(Console.ReadLine(), out num2) == false)
                {
                    Console.Clear();
                    Console.Write("Invlaid Input! Please Enter Second Number: ");
                }
                Console.Clear();

                switch (Operand)
                {
                    case "*":
                        double multiply = num1 * num1;
                        Console.WriteLine("Answer: " + multiply);
                        break;
                    case "/":
                        double division = num1 / num2;
                        Console.WriteLine("Answer: " + division);
                        break;
                    case "%":
                        double mod = num1 % num2;
                        Console.WriteLine("Answer: " + mod);
                        break;
                    case "+":
                        double add = num1 + num2;
                        Console.WriteLine("Answer: " + add);
                        break;
                    case "-":
                        double subtract = num1 - num2;
                        Console.WriteLine("Answer: " + subtract);
                        break;
                    default:
                        break;
                }

                Console.Write("------ Do You Want To Perform Another Calculation (Y/N)? ");
                playAgain = Console.ReadLine();
                Console.Clear();
            }

            Console.Write("------ Thank You For Using Calculator! ------");
        }
    }
}