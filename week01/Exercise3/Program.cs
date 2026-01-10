using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number? ");
        Random random = new Random();
        int magicNumber = random.Next(1, 101);  
        int parseNumber = 0;


        do
        {
        Console.WriteLine("What is your guess?");
        string userGuess = Console.ReadLine();
        parseNumber = int.Parse(userGuess); 

        if (parseNumber > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else if (parseNumber < magicNumber)
        {
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }

        } 
        while (parseNumber != magicNumber);

        
        

        
    }
}