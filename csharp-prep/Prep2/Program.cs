using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade percentage: ");
        string grade = Console.ReadLine();

        
        int x = int.Parse(grade);
        string gradeletter = "";

        if (x >= 90)
        {
            gradeletter = "A";
        }
        else if (x >= 80)
        {
            gradeletter = "B";
        }
        else if (x >= 70)
        {
            gradeletter = "C";
        }
        else if (x >= 60)
        {
            gradeletter = "D";
        }
        else if (x < 60)
        {
            gradeletter = "F";
        }

        Console.WriteLine($"Your grade is: {gradeletter}.");

        if (x >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class");
        }
        else{
            Console.WriteLine("You didn't pass the class, but You will do it better the next time");
        }
    }
}