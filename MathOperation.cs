// Modify the above program to call by reference (ref) so the original number get squared.
using System;

class MathOperation
{
    
    public void Square(ref int n)
    {
        n = n * n;  
    }
}

