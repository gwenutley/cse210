using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2000;
        job1._endYear = 2002;
        job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Web Designer";
        job2._startYear = 2003;
        job2._endYear = 2010;
        job2.DisplayJobDetails();

        Resume resume1 = new Resume();
        resume1._name = "Gwen Utley";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayResume();


    }
}