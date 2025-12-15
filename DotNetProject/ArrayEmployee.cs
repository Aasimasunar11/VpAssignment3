

// Task:
// Develop a C# console app that calculates the annual bonus for three employees based on their years of service and annual salary.
// Use jagged arrays to store employee data.

// Bonus Rules:

// Years of Service	Bonus Percentage
// 1–2 years	5% of salary
// 3–5 years	8% of salary
// 6–10 years	12% of salary
// >10 years	15% of salary
// ✅ Simple C# Code Using Jagged Arrayusing System;
using System;
class ArrayEmployee
{
    public void Account()
    {
    
        string[][] employees = new string[3][];

        for (int i = 0; i < employees.Length; i++)
        {
            employees[i] = new string[3];

            Console.WriteLine($"\nEnter details for Employee {i + 1}:");
            Console.Write("Name: ");
            employees[i][0] = Console.ReadLine();

            Console.Write("Annual Salary: ");
            employees[i][1] = Console.ReadLine();

            Console.Write("Years of Service: ");
            employees[i][2] = Console.ReadLine();
        }

        Console.WriteLine("\n--- Employee Bonus Report ---");

        for (int i = 0; i < employees.Length; i++)
        {
            string name = employees[i][0];
            double salary = Convert.ToDouble(employees[i][1]);
            int years = Convert.ToInt32(employees[i][2]);

            double bonusPercent = 0;

            if (years >= 1 && years <= 2)
                bonusPercent = 0.05;
            else if (years >= 3 && years <= 5)
                bonusPercent = 0.08;
            else if (years >= 6 && years <= 10)
                bonusPercent = 0.12;
            else if (years > 10)
                bonusPercent = 0.15;

            double bonus = salary * bonusPercent;

            Console.WriteLine($"\nEmployee: {name}");
            Console.WriteLine($"Salary: {salary}");
            Console.WriteLine($"Years of Service: {years}");
            Console.WriteLine($"Bonus: {bonus}");
        }
    }
}
