using System;

class Program
{
    static void Main(string[] args)
    {
       
        // Console.WriteLine("What is your magic number:?");
        // int magicnumber = int.Parse(Console.ReadLine());
        Random randomnumber = new Random();
        int magicnumber = randomnumber.Next(1,101);
        int guess = 0;

        while (guess != magicnumber){

            Console.WriteLine("What is your guess?:");
            guess = int.Parse(Console.ReadLine());

            if(guess > magicnumber){
                Console.WriteLine("Lower");
            }
            else if(guess < magicnumber){
                Console.WriteLine("Higher");
            }
            else if(guess == magicnumber){
                Console.WriteLine("You guessed it.");
            }
            else {
                Console.WriteLine("Error. Please try again.");
            }
        }
        
    }
}