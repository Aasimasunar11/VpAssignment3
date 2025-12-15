using System;

class BinaryToDecimal
{
    public void Number()
    {
        Console.Write("Enter a binary number: ");
        int binary = int.Parse(Console.ReadLine()); 
        int decimalNumber = 0, baseValue = 1; 

        
        for (int temp = binary; temp > 0; temp = temp / 10)
        {
            int lastDigit = temp % 10;      
            decimalNumber += lastDigit * baseValue;
            baseValue = baseValue * 2;     
        }

        Console.WriteLine("Decimal number = " + decimalNumber);
    }
}
