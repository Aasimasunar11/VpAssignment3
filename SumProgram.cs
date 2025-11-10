using System;

class SumProgram
{
    public void Sum()
    {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum;

        if (num1 == num2)
        {
            sum = 3 * (num1 + num2);
        }
        else
        {
            sum = num1 + num2;
        }

        Console.WriteLine("Result: " + sum);
    }
}
