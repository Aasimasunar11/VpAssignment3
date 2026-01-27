using System;

class Student
{
    public void Marks()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        int total = 0;
        int marks;

        // Loop for 5 subjects
        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Enter marks for subject " + i + ": ");
            marks = Convert.ToInt32(Console.ReadLine());
            total += marks;
        }

        double average = total / 5.0;

        Console.WriteLine("\nName: " + name);
        Console.WriteLine("Average Marks: " + average);
    }
}
