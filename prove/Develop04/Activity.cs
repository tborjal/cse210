using System;
using System.Diagnostics;
using System.Threading;

public class Activity
{
    private string _startingMessage;
    private string _endingMessage;
    private string _activityDescription;
    private string _activityName;
    static int _spinnerCounter = 0;
    static int _userSessionLengthInput = 0;
    static object _lock = new object();

    public Activity()
    {
        _spinnerCounter = _userSessionLengthInput = 0;
    }

    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }
    public void SetActivityDescription(string activityDescription)
    {
        _activityDescription = activityDescription;
    }

    public int GetUserSessionLengthInput()
    {
        return _userSessionLengthInput;
    }
    public void DisplayStartingtMessage()
    {
        _startingMessage = $"Welcome to the {_activityName}.";
        Console.WriteLine(_startingMessage);
        Console.WriteLine();
    }

    public void DisplayDescription()
    {
        Console.WriteLine(_activityDescription);
        Console.WriteLine();
    }
    public void DisplayEndingMessage()
    {
        _endingMessage = $"You have complete {_userSessionLengthInput} seconds of the {_activityName}.";

        Console.WriteLine();
        Console.WriteLine("Well done!");
        Console.Write("Please Wait. . .");
        DisplaySpinner(3);
        Console.WriteLine();
        Console.WriteLine(_endingMessage);
        DisplaySpinner(5);
        Console.Clear();
    }

  public void DisplaySpinner(int numSecondsToRun)
{
    // Convert the duration to milliseconds
    int millisecondsToRun = numSecondsToRun * 1000;

    // Store the original cursor position
    int originalCursorLeft = Console.CursorLeft;
    int originalCursorTop = Console.CursorTop;

    // Get the current time
    DateTime startTime = DateTime.Now;

    // Run the spinner
    while (true)
    {
        // Calculate the elapsed time
        TimeSpan elapsedTime = DateTime.Now - startTime;

        // If the elapsed time is greater than or equal to the duration, break out of the loop
        if (elapsedTime.TotalMilliseconds >= millisecondsToRun)
        {
            break;
        }

        // Get the current cursor position
        int currentCursorLeft = Console.CursorLeft;
        int currentCursorTop = Console.CursorTop;

        // Set the new cursor position
        Console.SetCursorPosition(currentCursorLeft + 1, currentCursorTop);

        // If the new cursor position is off the screen, move to the next line
        if (currentCursorLeft >= Console.BufferWidth - 1)
        {
            Console.SetCursorPosition(originalCursorLeft, currentCursorTop + 1);
        }

        // Delay for a bit
        System.Threading.Thread.Sleep(50);
    }

    // Restore the original cursor position
    Console.SetCursorPosition(originalCursorLeft, originalCursorTop);
}

    public void DisplayCountdown(int numSecondsToRun)
    {
        for (int i = numSecondsToRun; i >= 1; i--)
        {
            Console.WriteLine($"You may begin in: {i}");
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
        }
    }

    public void DisplayGetSessionLength()
    {
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        Console.Write("> ");
        _userSessionLengthInput = int.Parse(Console.ReadLine());
    }

    public void DisplayGetReady()
    {
        Console.WriteLine("Get ready...");
        Console.Write("Loading...");
        DisplaySpinner(5);
    }

    public void RunActivityParentStart()
    {
        DisplayStartingtMessage();
        DisplayDescription();
        DisplayGetSessionLength();
        DisplayGetReady();
        Console.Clear();
    }

    public void RunActivityParentEnd()
    {
        DisplayEndingMessage();
    }

}