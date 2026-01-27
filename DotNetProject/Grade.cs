using System;

class Grade
{
public void Gradesheet()
    {
        int subject1, subject2, subject3;
        double average;

       
        Console.Write("Enter marks for Subject 1: ");
        subject1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks for Subject 2: ");
        subject2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks for Subject 3: ");
        subject3 = Convert.ToInt32(Console.ReadLine());

       
        average = (subject1 + subject2 + subject3) / 3.0;

     
        Console.WriteLine("Average Marks: " + average);

      switch ((int)Math.Floor(average / 10))
        {
            case 10:
            case 9:
            case 8:
                Console.WriteLine("Grade: A");
                break;
            case 7:
            case 6:
                Console.WriteLine("Grade: B");
                break;
            case 5:
            case 4:
                Console.WriteLine("Grade: C");
                break;
            default:
                Console.WriteLine("Grade: F (Fail)");
                break;
        }
    }
}

