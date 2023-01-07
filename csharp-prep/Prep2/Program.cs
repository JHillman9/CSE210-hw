using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string sGrade = Console.ReadLine();
        int grade = int.Parse(sGrade);
        string lGrade = "F";

        if (grade >= 90)
        {
            lGrade = "A";
        }
        else if (grade >= 80)
        {
            lGrade = "B";
        }
        else if (grade >= 70)
        {
            lGrade = "C";
        }
        else if(grade >= 60)
        {
            lGrade = "D";
        }
    Console.WriteLine($"You have an {lGrade} in the class");

        if (grade > 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else
        {
            Console.WriteLine("You failed the class");
        }


    }
}