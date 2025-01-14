using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int gradePercentage = int.Parse(input);

        string grade = "";
        string sign = "";
        if (gradePercentage >= 90) {
            grade = "A";  
            if (gradePercentage <= 93){
                sign = "-";
            }
        }

        else if (gradePercentage >= 80) {
            grade = "B";

            if (gradePercentage >= 87){
                sign = "+";
            } 
            else if (gradePercentage <= 83){
                sign = "-";
            }
        }

        else if (gradePercentage >= 70) {
            grade = "C";  
            if (gradePercentage >= 77){
                sign = "+";
            } 
            else if (gradePercentage <= 73){
                sign = "-";
            }
        }

        else if (gradePercentage >= 60) {
            grade = "D"; 
            if (gradePercentage >= 67){
                sign = "+";
            } 
            else if (gradePercentage <= 63){
                sign = "-";
            }   
        }
        else if (gradePercentage < 60) {
            grade = "F"; 
        }

        Console.WriteLine(grade+sign);
        
        if (gradePercentage >= 70){
            Console.WriteLine("Congradulations, you passed!");
        }
        
        else if (gradePercentage < 70) {
            Console.WriteLine("Try harder next time.");
        }

    }
}