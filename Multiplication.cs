using System;

class Multiplication
{
    public void Multi()
    {
    
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter third number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        
        int result = num1 * num2 * num3;

    
        Console.WriteLine($"\nThe multiplication of {num1}, {num2}, and {num3} is: {result}");
    }
}
