using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Developer";
        job1._company = "Secons2None Services";
        job1._startYear = 2019;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Access Bank";
        job2._startYear = 2012;
        job2._endYear = 2020;

        Resume jobResume = new Resume();
        jobResume._name = "Attah collins";

        jobResume._jobs.Add(job1);
        jobResume._jobs.Add(job2);

        jobResume.Display();
    }
}