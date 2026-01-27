// write a program that calculates the square of a number using call by value and the original number change.
using System;

class Calculator
{
   
    public int SquareByValue(int n)
    {
        n = n * n;   
        return n;
    }

    
    public void SquareByReference(ref int n)
    {
        n = n * n;  
    }
}
    
