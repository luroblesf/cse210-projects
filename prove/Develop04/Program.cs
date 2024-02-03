using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("------ Welcome to Mindfulness Program ------");
    
        while (true) 
        {
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine();
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Physical Activity");
            Console.WriteLine("5. Quit");
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
         
            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.RunActivity();
                    breathingActivity.PromptBreathing();
                    breathingActivity.DisplayEndMessage();
                    
                    break;

                case "2":
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.RunActivity();
                    reflectionActivity.DisplayRandomPrompt();
                    reflectionActivity.DisplayEndMessage();

                    break;

                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.RunActivity();
                    listingActivity.GetListFromUser();
                    listingActivity.DisplayEndMessage();

                    break;

                case "4":
                    PhysicalActivity physicalActivity = new PhysicalActivity();
                    physicalActivity.RunActivity();
                    physicalActivity.PromptMovements();
                    physicalActivity.DisplayEndMessage();

                    break;

                case "5":
                    Console.WriteLine();
                    Console.WriteLine("Thank you for using Mindfulness Program!");
                    Console.WriteLine();
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine();
                    break;
            }
        }
    }
}