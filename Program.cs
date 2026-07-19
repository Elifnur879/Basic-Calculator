using System;
class Calculator
{
    static void Main()
    {
        Console.WriteLine(" --- Basic Calculator --- ");

        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Choose the operation (+, -, *, /): ");
        string operation = Console.ReadLine();

        double result = 0;
        bool isThereMistakes = false;

        if (operation == "+")
        {
            result = num1 + num2;
        }
        else if (operation == "-")
        {
            result -= num1 - num2;
        }
        else if (operation == "*")
        {
            result = num1 * num2;
        }
        else if (operation == "/")
        { 
            if(num2 == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero!");
                isThereMistakes = true;
            }
            else
            {
                result = num1 / num2;
            }
        }
        else
        {
            Console.WriteLine("Invalid Operation!");
        }

        if (!isThereMistakes)
        {
            Console.WriteLine("Sonuç: " + result);
        }
    }

}
