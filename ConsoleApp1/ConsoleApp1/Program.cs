using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator App!");

            while (true)
            {
                Console.WriteLine("Please enter the first number:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the second number:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please select an operation (+, -, *, /):");
                char operation = Convert.ToChar(Console.ReadLine());

                double result = 0;

                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        result = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("Invalid operation selected.");
                        break;
                }

                Console.WriteLine($"The result of {num1} {operation} {num2} is: {result}");

                Console.WriteLine("Do you want to perform another calculation? (Y/N)");
                string continueCalculation = Console.ReadLine();

                if (continueCalculation.ToUpper() != "Y")
                {
                    break;
                }
            }

            Console.WriteLine("Thank you for using the Calculator App!");
        }
    }
}
