using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Sotftware Engineer";
        job1._company = "Ubisoft";
        job1._startYear = 2013;
        job1._endYear = 2021;

       

        // Create second job instance 
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Epic Games";
        job2._startYear = 2021;
        job2._endYear = 2024;

        // Add two jobs created earlier to list in Resume class 
        // Initialize new instance of Resume class:
        Resume currentResume = new Resume();

        // Add two jobs to the list within Resume 
        currentResume._jobs.Add(job1);
        currentResume._jobs.Add(job2);

        // Call resume display method 
        currentResume.Display();
        
    }
}