using System;
using System.Drawing;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        /*Console.Write("What is the magic number? ");
        String answer = Console.ReadLine();
        int magicNumber = int.Parse(answer);

        Console.Write("What is your guess? ");
        string response = Console.ReadLine();
        int guess = int.Parse(response);
        */

        int guess = -1; 

        while (guess != magicNumber)
        {
            Console.Write("What is your guess?");
            guess = int.Parse(Console.ReadLine());
        
            if (guess < magicNumber)
            {
                Console.WriteLine("higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}