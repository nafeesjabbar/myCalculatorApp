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

            Console.WriteLine("------ Console Calculator in C# ------");

            while (playAgain == "Y" || playAgain == "y")
            {
                Console.Write("Type in a number, then press Enter: ");

                while (Double.TryParse(Console.ReadLine(), out num1) == false)
                {
                    Console.Clear();
                    Console.Write("Invlaid Input! Type in a number, then press Enter: ");
                }
                Console.Clear();

                Console.Write("Type in operand, then press Enter: [ * ], [ / ], [ % ], [ + ], [ - ] ");
                Operand = Convert.ToString(Console.ReadLine());

                while (!Operand.Equals("*") && !Operand.Equals("/") && !Operand.Equals("%") && !Operand.Equals("+") && !Operand.Equals("-"))
                {
                    Console.Clear();
                    Console.Write("Invalid Input! Type in operand, then press Enter: [ * ], [ / ], [ % ], [ + ], [ - ] ");
                    Operand = Convert.ToString(Console.ReadLine());
                }
                Console.Clear();

                Console.Write("Type in a number, then press Enter: ");

                while (Double.TryParse(Console.ReadLine(), out num2) == false)
                {
                    Console.Clear();
                    Console.Write("Invlaid Input! Type in a number, then press Enter: ");
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

                Console.Write("------ To perform another calculation, Type 'Y', then press Enter. To finish Enter any key: ");
                playAgain = Console.ReadLine();
                Console.Clear();
            }

            Console.Write("------ End of application! ------");
        }
    }
}