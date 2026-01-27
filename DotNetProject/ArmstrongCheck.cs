using System;

class ArmstrongCheck
{
    public void Armstrong()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int temp = num;
        int sum = 0;

        while (temp > 0)   
        {
            int digit = temp % 10;
            sum = sum + (digit * digit * digit);  
            temp = temp / 10;
        }

        if (sum == num)
            Console.WriteLine(num + " is an Armstrong number.");
        else
            Console.WriteLine(num + " is not an Armstrong number.");
    }
}
