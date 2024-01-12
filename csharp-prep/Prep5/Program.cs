using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayMessage();
        string enterName = PromptUserName();
        int enterNumber = PromptUserNumber();
        int total = SquareNumber(enterNumber);

        DisplayResult(enterName,total);
    
        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }
    
        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number: ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }

        static int SquareNumber(int userNumber)
        {
            int result = userNumber * userNumber;
            return result;
        }

        static void DisplayResult(string userName, int result)
        {
            Console.WriteLine($"{userName}, the square of your numbre is {result}");
        }
    }
}