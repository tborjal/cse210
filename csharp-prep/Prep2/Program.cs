using System;

Console.WriteLine("Hello Prep2 World!");

Console.WriteLine("What is your grade?:");
string input = Console.ReadLine();
int grade = int.Parse(input);


string letter = "";

    if (grade >= 90)
{
       letter = "A";
}
    else if (grade >= 80)
{
        letter = "B";
}
    else if (grade >= 70)
{
        letter = "C";
}
    else if (grade >= 60)
{
        letter = "D";
}
    else if (grade < 60)
{
       letter = "F";
}
    else
{
        Console.WriteLine("Error. Please try again");
}

    Console.WriteLine($"Your grade is: {letter} ");

    if (grade >= 70){
        Console.WriteLine("Good Job! You passed.");
    }
    else if(grade <=69){

        Console.WriteLine("You can still try again. Better luck next time!");
    }
    else {
        Console.Write("Error, Please try again.");
    }


