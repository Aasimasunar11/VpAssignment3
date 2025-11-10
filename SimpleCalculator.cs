using System;

class SimpleCalculator
{
    public void Calculator()
    {
        Console.WriteLine("=== Simple Calculator ===");
        Console.WriteLine("Allowed operations: +  -  *  /  %  sqrt");

        Console.Write("Enter first number: ");
        string? input1 = Console.ReadLine();
        if (!double.TryParse(input1, out double num1))
        {
            Console.WriteLine("Invalid number input!");
            return;
        }

        Console.Write("Enter operation (+, -, *, /, %, sqrt): ");
        string? op = Console.ReadLine();
        if (op == null)
        {
            Console.WriteLine("Invalid operation input!");
            return;
        }

        if (op == "sqrt")
        {
            double result = Math.Sqrt(num1);
            Console.WriteLine("Result: √{0} = {1}", num1, result);
        }
        else
        {
            Console.Write("Enter second number: ");
            string? input2 = Console.ReadLine();
            if (!double.TryParse(input2, out double num2))
            {
                Console.WriteLine("Invalid number input!");
                return;
            }

            double result = 0;
            bool valid = true;

            if (op == "+")
                result = num1 + num2;
            else if (op == "-")
                result = num1 - num2;
            else if (op == "*")
                result = num1 * num2;
            else if (op == "/")
            {
                if (num2 != 0)
                    result = num1 / num2;
                else
                {
                    Console.WriteLine("Error: Division by zero!");
                    valid = false;
                }
            }
            else if (op == "%")
                result = num1 % num2;
            else
                valid = false;

            if (valid)
                Console.WriteLine("Result: {0} {1} {2} = {3}", num1, op, num2, result);
            else if (op != "/" || num2 == 0)
                Console.WriteLine("Invalid operation!");
        }

        Console.WriteLine("Program ended.");
    }
}

