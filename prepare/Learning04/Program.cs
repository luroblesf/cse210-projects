using System;
namespace activityW4
{

    class Program
    {
        static void Main(string[] args)
        {
            Assigments assignment1 = new Assigments();
            assignment1.SetStudentName("Samuel Bennett");
            assignment1.SetTopic("Multiplication");

            Console.WriteLine(assignment1.GetSummary());
            Console.WriteLine();

            MathAssigments assignment2 = new MathAssigments();
            assignment1.SetStudentName("Roberto Rodriguez");
            assignment1.SetTopic("Fractions");
            assignment2.SetTextBook("7.3");
            assignment2.SetProblems("8-19");

            Console.WriteLine(assignment1.GetSummary());
            Console.WriteLine(assignment2.GetHomeworkList());
            Console.WriteLine();

            WritingAssignments assignment3 = new WritingAssignments();
            assignment1.SetStudentName("Mary Waters");
            assignment1.SetTopic("European History");
            assignment3.SetTitle("The Causes of World War II","Mary Waters");

            Console.WriteLine(assignment1.GetSummary());
            Console.WriteLine(assignment3.GetWritingInformation());
        }
    }
}