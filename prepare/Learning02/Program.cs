using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job("Del Taco", "Manager", 1706, 2020);
        Job job2 = new Job("Google", "CTO", 2020, 2024);

        // job1._company = "Del Taco";
        // job1._jobTitle = "Manager";
        // job1._startYear = 1706;
        // job1._endYear = 2020;

        // Job job2 = new Job();
        // job2._company = "Google";
        // job2._jobTitle = "CTO";
        // job2._startYear = 2020;
        // job2._endYear = 2024;

        Resume res = new Resume();
        res._name = "Jake Maynes";

        res._jobs.Add(job1);
        res._jobs.Add(job2);


        res.Display();
    }
}