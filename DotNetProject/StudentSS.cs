using System;

class StudentSS
{
    public void SSS()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter number of subjects: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int total = 0;
        int marks;

        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter marks for subject " + i + ": ");
            marks = Convert.ToInt32(Console.ReadLine());
            total += marks;
        }

        double average = total / (double)n;

        Console.WriteLine("\nName: " + name);
        Console.WriteLine("Average Marks: " + average);
    }
}
