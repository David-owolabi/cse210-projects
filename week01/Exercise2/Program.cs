using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string gradePercentage = Console.ReadLine();

        int newPercentage = int.Parse(gradePercentage);

        string letter = "";


        if (newPercentage < 60)
        {
            letter = "F";
        }
        else if (newPercentage >= 60 && newPercentage < 70)
        {
            letter = "D";
        }
        else if (newPercentage >= 70 && newPercentage < 80)
        {
            letter = "C";
        }
        else if (newPercentage >= 80 && newPercentage < 90)
        {
            letter = "B";
        }
        else
        {
            letter = "A";
        }


        int lastDigit = newPercentage % 10;
        if (lastDigit >=7 && newPercentage != 100 && letter != "F")
        {
            letter += "+";
        }
        else if (lastDigit < 3)
        {
            letter += "-";
        }                     

        Console.WriteLine($"Your letter grade is {letter}.");



        if (newPercentage >= 70)
        {
            Console.WriteLine("Congratulations! You have passed the course.");
        }
        else
        {
            Console.WriteLine("Unfortunately, you have not passed the course. Better luck next time!");
        }
    }
}