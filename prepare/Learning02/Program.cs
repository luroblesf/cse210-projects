using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();        
        job1._jobTitle = "Software Engineer";
        job1._nameCompany = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        //job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._nameCompany = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        //job2.Display();
     
        Resume resumePersonal = new Resume();
        resumePersonal._name = "Allison Rose";

        resumePersonal._jobs.Add(job1);
        resumePersonal._jobs.Add(job2);

        resumePersonal.Display();

    }
}