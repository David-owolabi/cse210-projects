using System;

class Program
{
    static void Main(string[] args)
    {   
        DisplayWelcome();
        string name = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(favoriteNumber);

        DisplayResult(name, squaredNumber); 

    }
     static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            return Console.ReadLine();
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            return int.Parse(Console.ReadLine());
        }
    
        static int SquareNumber(int number)
        {
            int squared = number * number;
            return squared;
        }

            static void DisplayResult(string name, int squaredNumber)
        {
            Console.WriteLine($"Brother {name}, the square of your number is {squaredNumber}.");
        }

}