// write and c sharp program thhat swap two number using call by value.
using System;

class Swapper
{
    
    public void Swap(int a, int b)
    {
        Console.WriteLine("\nInside Swap method (before swapping): a = {0}, b = {1}", a, b);

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("Inside Swap method (after swapping): a = {0}, b = {1}", a, b);
    }
}
