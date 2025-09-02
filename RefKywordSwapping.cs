// write and c sharp program thhat swap two number using ref keyboard. show that the value change outside the method.
using System;

class RefKywordSwapping
{
    
    public void Swap(ref int a, ref int b) 


    {
        Console.WriteLine("\nInside Swap method (before swapping): a = {0}, b = {1}", a, b);

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("Inside Swap method (after swapping): a = {0}, b = {1}", a, b);
    }
}


