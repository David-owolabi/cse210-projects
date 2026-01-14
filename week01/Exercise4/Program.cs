using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        List<int> numbers = new List<int>(); //intialize a list to hold numbers

        // a do while loop to add numbers to the list
        int number;
        do
        {
            Console.WriteLine("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
                numbers.Add(number);
        
        }
        while (number != 0);

        // calculate the sum of the numbers in the list using a foreach loop
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        double average = (double)sum / numbers.Count; // calculate the average
        int largestNumber = numbers.Max(); // find the largest number using LINQ

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        numbers.Sort(); // sort the list from smallest to largest
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }


        
    }
}