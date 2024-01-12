using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        
        int userinfo = 1;

        do
        {
            Console.WriteLine("Enter number: ");
            userinfo = int.Parse(Console.ReadLine());

            if (userinfo !=0)
            {
                numbers.Add(userinfo);
            }

        } while (userinfo != 0);

        int sum = 0;
        int max = numbers[0];

        foreach (int number in numbers)
        {
            sum += number;

            if (number > max)
            {
                max = number;
            }
            
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        Console.WriteLine($"The largest number is: {max}");  
    }
}