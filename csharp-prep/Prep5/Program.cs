using System;

class Program
{
    static void Main(string[] args)
    {
    Console.WriteLine("Hello Prep5 World!");

    DisplayWelcomeMessage();

    string userName = PromptUserName();
    int userNumber = PromptUserNumber();

    int squaredNumber = SquareNumber(userNumber);

    DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
    Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
    Console.Write("Please enter your name: ");
    Console.Out.Flush(); // Flush the output to ensure prompt is displayed immediately
    string name = Console.ReadLine();

    return name;
    }

    static int PromptUserNumber()
    {
    Console.Write("Please enter your favorite number: ");
    Console.Out.Flush(); // Flush the output to ensure prompt is displayed immediately
    int number = int.Parse(Console.ReadLine());

    return number;
    }

    static int SquareNumber(int number)
    {
    int square = number * number;
    return square;
    }

    static void DisplayResult(string name, int square)
    {
    Console.WriteLine($"Brother {name}, the square of your number is {square}");
    }


}