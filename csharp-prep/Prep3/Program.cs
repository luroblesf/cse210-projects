using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number? ");
        int x = int.Parse(Console.ReadLine());

        //Random randomGenerator = new Random();
        //int x = randomGenerator.Next(1,101);

        int y = 1;

        do
        {
            Console.WriteLine("What is your guess? ");
            y = int.Parse(Console.ReadLine());

            string result = "";

            if (y < x)
            {
                result = "Higher";
            }
            else if (y > x)
            {
                result = "Lower";
            }
            else if (y == x)
            {
            result = "You guessed it!";
            }

            Console.WriteLine($"{result}");

        } while (y != x);
    }
}
