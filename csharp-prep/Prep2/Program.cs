using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string response = Console.ReadLine();
        int percentage = int.Parse(response);

        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }

        else if (percentage >= 80)
        {
            letter = "B";
        }

        else if (percentage >= 70)
        {
            letter = "C";
        }

        else if (percentage >= 60)
        {
            letter = "D";
        }

        else (percentage < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}.");

        if (percentage >= 70)
        {
            Console.WriteLine("You passed!");
        }

        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}