using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exerciseList = new List<Exercise>();
        
        Running running = new Running("February 25, 2024", 35, 5.2);
        exerciseList.Add(running);

        StationaryBicycles stationaryBicycles = new StationaryBicycles("March 7, 2024", 50, 10);
        exerciseList.Add(stationaryBicycles);

        Swimming swimming = new Swimming("March 26, 2024", 10, 15);
        exerciseList.Add(swimming);

        Console.WriteLine("Exercises:");
        Console.WriteLine();

        foreach (Exercise exercise in exerciseList) 
        {
            Console.WriteLine(exercise.GetSummary());
        }

        Console.WriteLine();
    }
}
