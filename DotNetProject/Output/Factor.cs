using System;

class Factor
{
    public void Fact()
    {

        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int fact = 1;

        for (int i = 1; i <= n; i++)
        {
            fact = fact * i;
        }

        Console.WriteLine("Factorial of " + n + " is: " + fact);
    }
    }

