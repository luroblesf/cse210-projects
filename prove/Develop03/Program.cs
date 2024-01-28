using System;

namespace ScriptureMemorizer
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Scripture scripture = new Scripture("John", 3, 16,"For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
            Console.Clear();
            scripture.Display(); 
            Console.WriteLine();
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;

                if (!scripture.HideRandomWord())
                {
                    Console.WriteLine("You did it! Excellent Job!");
                    break;
                }

                Console.Clear();
                scripture.Display();
                Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
            }
        }
    }
}