using System;

class MultiplicationTable
{
 public void Multi()
    {
        int num = 5; 
        int i = 1;

        while (i <= 10)
        {
            Console.WriteLine(num + " x " + i + " = " + (num * i));
            i++;
        }
    }
}
