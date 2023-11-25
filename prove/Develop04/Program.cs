using System;


class Program
{
    static void Main(string[] args)
    {
        DateTime Timex = DateTime.Now;
        int breatheCount = 0;
        int reflectCount = 0;
        int listCount = 0;
        Console.Clear();
        
        Console.WriteLine("Welcome to the Mindfulness Program!");
        Console.WriteLine();
        bool running = true;
        while (running)
        {   
            Console.WriteLine(Timex.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine();
            Console.WriteLine("Select a choice from menu:");
            Console.Write("> ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {   
                //Breathing
                case 1:
                    Console.Clear();
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.RunBreathingActivity();
                    breatheCount++;
                    break;
                //Reflecting
                case 2:
                    Console.Clear();
                    ReflectingActivity reflection = new ReflectingActivity();
                    reflection.RunReflectingActivity();
                    reflectCount++;
                    break;
                //Listing
                case 3:
                    Console.Clear();
                    ListingActivity listing = new ListingActivity();
                    listing.RunListingActivity();
                    listCount++;
                    break;
                //quit
                case 4:
                    running = false;
                    Console.WriteLine("-------Result--------");
                    Console.WriteLine("Great job! You completed the following activities: ");
                    Console.WriteLine($"Breathing Activity: {breatheCount} times");
                    Console.WriteLine($"Reflecting Activity: {reflectCount} times");
                    Console.WriteLine($"Listing Activity: {listCount} times");
                    Console.WriteLine();
                    Console.WriteLine("Thank you! Good bye!");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please choose one of the following activities.");
                    break;
            }
     
        }
    }
}