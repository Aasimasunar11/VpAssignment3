using System;

class Swap
{
    public void Swapping()
    {
        
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"\nBefore swapping: num1 = {num1}, num2 = {num2}");

        
        int temp = num1;
        num1 = num2;
        num2 = temp;

        Console.WriteLine($"After swapping: num1 = {num1}, num2 = {num2}");
    }
}
