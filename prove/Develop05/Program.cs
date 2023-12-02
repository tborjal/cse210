using System;

class Program
{
    static void Main(string[] args)
    {
     
        AllGoals allGoals = new AllGoals();
        int userMainMenuSelection = 0;
        

        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("Welcome to the Goal Setter Game !");
        DateTime Timex = DateTime.Now;
        Console.WriteLine(Timex.ToString("dddd, dd MMMM yyyy"));
        while (userMainMenuSelection != 6)
        {
            Menu menu = new Menu();
            
          
            menu.DisplayMainMenu();
            userMainMenuSelection = int.Parse(Console.ReadLine());
            allGoals.DisplayPoints(allGoals.getTotalPoints());
            Console.Clear();

            switch (userMainMenuSelection)
            {
                //Menu Selection
                case 1:
                    menu.DisplayNewGoalMenu();
                    int userNewGoalSelection = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Goal goal = null;
                    if (userNewGoalSelection == 1)
                    {
                        goal = new SimpleGoal();
                        goal.DisplayGoalName();
                        goal.DisplayGoalDescription();
                        goal.DisplayGoalPoints();
                    }
                    else if (userNewGoalSelection == 2)
                    {
                        goal = new EternalGoal();
                        goal.DisplayGoalName();
                        goal.DisplayGoalDescription();
                        goal.DisplayGoalPoints();
                    }
                    else
                    {
                        goal = new CheckListGoal();
                        goal.DisplayGoalName();
                        goal.DisplayGoalDescription();
                        goal.DisplayGoalPoints();
                    }

                    if (goal != null)
                    {
                        allGoals.addGoal(goal);
                    }
                    break;
                //Display Goals
                case 2:
                    allGoals.DisplayGoals();
                    break;
                //Save File
                case 3:
                    allGoals.SaveGoals();
                    break;
                //Load Section
                case 4:
                    allGoals.LoadGoals();
                    break;
              //Goal History
                case 5:
                    allGoals.DisplayGoalRecordEvent();
                    break;
                //End Program
                case 6:
                    Console.WriteLine("Thank you! Have a great day!!! ");
                    break;
                //Error Message
                default:
                    Console.WriteLine("Error Input !!!");
                    Console.WriteLine("Choose to the Menu Option"); 
                    break;

            }
            
        }
        
    }
}