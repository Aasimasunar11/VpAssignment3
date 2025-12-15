using System;

class ArithmeticOperations
{
    public void Arithmetic()
    {
        
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());


        double sum = num1 + num2;
        double diff = num1 - num2;
        double prod = num1 * num2;
        double div = num2 != 0 ? num1 / num2 : 0;  

        
        Console.WriteLine($"\nAddition: {sum}");
        Console.WriteLine($"Subtraction: {diff}");
        Console.WriteLine($"Multiplication: {prod}");
        if (num2 != 0)
            Console.WriteLine($"Division: {div}");
        else
            Console.WriteLine("Division: Cannot divide by zero");
    }
}
