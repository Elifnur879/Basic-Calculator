using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
class Calculator
{
    static void Main()
    {
        List<string> history = new List<string>();
        
        string anotherOne = "y";
         
        while (anotherOne == "y" ) {

            Console.WriteLine(" --- Basic Calculator --- ");

            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Choose the operation (+, -, *, /, %, ^): ");
            string operation = Console.ReadLine();

            double result = 0;
            bool isThereMistakes = false;

            if (operation == "+")
            {
                result = num1 + num2;
            }
            else if (operation == "-")
            {
                result = num1 - num2;
            }
            else if (operation == "*")
            {
                result = num1 * num2;
            }
            else if (operation == "/")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Cannot divide by zero!");
                    isThereMistakes = true;
                }
                else
                {
                    result = num1 / num2;
                }
            }
            else if (operation == "%")
            {
                result = num1 % num2;
            }
            else if (operation == "^")
            {
                result = Math.Pow(num1, num2);
            }
            else
            {
                Console.WriteLine("Invalid Operation!");
                isThereMistakes = true;
            }

            if (!isThereMistakes)
            {
                Console.WriteLine("Result: " + result);
                history.Add(num1 + " " + operation + " " + num2 + " = " + result);
            }

            Console.WriteLine("Do you want to do another operation? (y/n): ");

            anotherOne = Console.ReadLine();
        }

        Console.WriteLine("\n === Calculation History ===");
        foreach(string record in history)
        {
            Console.WriteLine(record);
        }
        
    }

}
