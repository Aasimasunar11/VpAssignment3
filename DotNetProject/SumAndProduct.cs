// write a method that returns the sum and product of two numbers using out parameter. 
using System;

class SumAndProduct
{
   
    public void Calculate(int a, int b, out int sum, out int product)
    {
        sum = a + b;
        product = a * b;
    }
}

