using System;

class Program
{
    static void Main(string[] args)
    {
        string letterGrade = "F";
        Console.WriteLine("What grade did you recieve?");
        string gradeInput = Console.ReadLine();
        int grade = int.Parse(gradeInput);

        if (grade >= 60)
        {
            letterGrade = "D";
            if (grade >= 70)
            {
                letterGrade = "C";
                if (grade >= 80)
                {
                    letterGrade = "B";
                    if (grade >= 90)
                    {
                        letterGrade = "A";
                    }
                }
            }
        }
        

        Console.WriteLine($"Your letter grade is: {letterGrade}");
    }
}