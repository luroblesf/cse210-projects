using System;
using System.IO;
using System.IO.Enumeration;


class Program
{
    static void Main(string[] args)
{
    Journal journal = new Journal();

    Console.WriteLine("Welcome to Journal Program!");
    
    while (true) 
    {
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();
     
            switch (choice) 
            {
                case "1":
                {
                    string journalFile = "journal.txt";
                    File.AppendAllText(journalFile, "");   
                 
                    journal.AddEntry();
                    break;
                }
                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    journal.LoadFromFile();
                    break;

                case "4":
                    journal.SaveToFile();
                    break;

                case "5":
                    Console.WriteLine("Have a nice day!");
                    return;

                default:
                    Console.WriteLine("Invalid selection, try again.");
                    break;
            }

        }
    }
}