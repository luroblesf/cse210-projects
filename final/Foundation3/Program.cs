using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("Conference Center", "Salt Lake City", "Utah", "USA");

        Lecture lecture = new Lecture("General Conference", "The Church of Jesus Christ of Latter-Day Saints", "April 6, 2024", "10:00am - 12:00pm MT", address, "Pres. Russell M. Nelson", 21000);
        Console.WriteLine();

        Console.WriteLine("Event Number: 1");
        Console.WriteLine();
        Console.WriteLine(lecture.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(lecture.GenerateDetailedLecture());

        Console.WriteLine();
        Console.WriteLine(lecture.GenerateShortLecture());

        Address addressR = new Address("128 N Nevada Ave", "Colorado Springs", "Colorado", "USA");

        Reception reception = new Reception("Pivot Program", "Dance Alliance of the Pikes Peak Region", "March 1, 2024", "10:30 - 11:30am PDT", addressR, "info@dappr.org");
        Console.WriteLine();

        Console.WriteLine("Event Number: 2");
        Console.WriteLine();
        Console.WriteLine(reception.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(reception.GenerateDetailedReception());

        Console.WriteLine();
        Console.WriteLine(reception.GenerateShortReception());

        Address addressOG = new Address("Central Park", "Quetzaltenango", "Quetzaltenango", "Guatemala");

        OutdoorGathering outdoorGathering = new OutdoorGathering("Mother's Day Special!", "I love my Mother", "May 14, 2024 ", "5:30 - 7:30pm PDT", addressOG, "sunny");
        Console.WriteLine();

        Console.WriteLine("Event Number: 3");

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateDetailedOutdoorGathering());

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateShortOutdoorGathering());
        Console.WriteLine();
    }
}