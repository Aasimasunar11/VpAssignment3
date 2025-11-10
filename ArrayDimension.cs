
// reates a normal array of 1, 2, 3

// Creates a jagged array

// Takes double-type inputs from the user

// Displays all values
using System;
class ArrayDimension
{
    public void Array()
    {
        // Normal array
        int[] arr = { 1, 2, 3 };
        Console.WriteLine("Normal Array Elements:");
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine("\n");

        // Jagged array
        double[][] jagged = new double[2][]; // 2 rows
        jagged[0] = new double[3];
        jagged[1] = new double[2];

        Console.WriteLine("Enter 5 double values for jagged array:");
        for (int i = 0; i < jagged.Length; i++)
        {
            for (int j = 0; j < jagged[i].Length; j++)
            {
                Console.Write($"Enter value for jagged[{i}][{j}]: ");
                jagged[i][j] = Convert.ToDouble(Console.ReadLine());
            }
        }

        // Display jagged array
        Console.WriteLine("\nJagged Array Elements:");
        for (int i = 0; i < jagged.Length; i++)
        {
            for (int j = 0; j < jagged[i].Length; j++)
            {
                Console.Write(jagged[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
