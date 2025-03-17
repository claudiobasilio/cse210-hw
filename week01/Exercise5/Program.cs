using System;
using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // Step 1 
        DisplayWelcome();

        // Step 2 
        string userName = PromptUserName(); 

        // Step 3 
        int favoriteNumber = PromptUserNumber();


        // Step 4
        int squaredNumber = SquareNumber(favoriteNumber);

       // Step 5
        DisplayResult(userName, squaredNumber);
        
        /*Console.Write("Please enter your favorite number? ");
        string number = Console.ReadLine();
        int integer = int.Parse(number);
        integer * integer = answer*/

    }

    // First function 
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Second function
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Third function
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number:" );
        string input = Console.ReadLine();
        int number = int.Parse(input);
        return number;
    }

    // Forth function
    static int SquareNumber(int number)
    {
        return number * number; 
    }

    // 5th function 
    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.Write($"{userName}, the square of your number is {squaredNumber}");
    }

}