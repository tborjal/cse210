using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //User Input
        Journal currentJournal = new Journal();
            string _Userchoice = "";
        
        //Menu Section
        do
        {
            //Menu Choice If Else According to the User desire
            Menu();
                    Console.WriteLine("What do you like to do ? ");
                        Console.Write("> ");
            //User Input 
                    _Userchoice = Console.ReadLine();
            //Write
            if (_Userchoice == "1")
            {
                    //Insert Data 
                    Console.Clear();
                        _UserEntry currentEntry = _User_New_Entry();
                            currentJournal._entries.Add(currentEntry);
            }
            //Display
            else if (_Userchoice == "2")
            {       
                    Console.Clear();
                        currentJournal.Display();
            }
            //Load a data file
            else if (_Userchoice == "3")
            {
                    Console.Clear();
                        currentJournal = new Journal();
                            Console.WriteLine("What is the name of the file you would like to Load?");
                                Console.Write("> ");
                                    currentJournal._name = Console.ReadLine();
                                        currentJournal.Load();
            }
            //Save the Data input in the write
            else if (_Userchoice == "4")
            {
                    currentJournal.Save();
            }
            //Quit Button if the user wants to end the program he will choose this section
            else if (_Userchoice != "5")
            {
                // If the user input a another data that does relate in the menu it will show Error Hanlding
                    Console.WriteLine("Please select an option from the menu! Error 404");
            }
        }
        while (_Userchoice != "5");
    }
    //Menu Bar Loop
    //Menu Showing the menus in the start
    public static void Menu()
    {  //Message Introduction
                    Console.WriteLine("Welcome to the Journal Program!");
                    Console.WriteLine("1. Write");
                    Console.WriteLine("2. Display");
                    Console.WriteLine("3. Load");
                    Console.WriteLine("4. Save");
                    Console.WriteLine("5. Quit");
    }
    //Entry Method User Data Input
    static _UserEntry _User_New_Entry()
    {
        _UserEntry currentEntry = new _UserEntry();
            //Adding a data Date and Time
                DateTime date = DateTime.Today;
                    currentEntry._date = date.ToShortDateString();
        //Custom 
                    Console.WriteLine("Would you like custom Write?(Y/N)");
                        Console.Write("> ");
        //Questions Promp
        string promptQuestion = Console.ReadLine();
        //If the User say N it will randomly Choose the Questions
        if (promptQuestion.ToLower() == "n")
        {
            currentEntry._entryPrompt = Question();
                Console.WriteLine($"{currentEntry._entryPrompt}");
                    Console.Write("> ");
        }
        //It will Customize the User data Questions
        else if (promptQuestion.ToLower() == "y")
        {
            currentEntry._entryPrompt = "Custom Write!";
                Console.WriteLine("Type your custom Write Here!");
                    Console.Write("> ");
        }

        currentEntry._response = Console.ReadLine();

        return currentEntry;
    }
    //Question Section
    static string Question()
    {
        List<string> prompts = new List<string>()
                {
                    //Random Qustion
                    "Who was the most interesting person I interacted with today?",
                        "What was the best part of my day?",
                            "How did I see the hand of the Lord in my life today?",
                                "What was the strongest emotion I felt today?",
                                    "If I had one thing I could do over today, what would it be?",
                                        "What is your Favorite food?",
                };
        var random = new Random();
            return prompts[random.Next(prompts.Count)];
    }
    // List Data Display
    public class Journal
    {
        //Variable and List
        public string _name;
            public List<_UserEntry> _entries = new List<_UserEntry>();
        //Display Section
        public void Display()
        {
            
            foreach (_UserEntry data in _entries)
            {
                Console.WriteLine($"{data._date} {data._entryPrompt} {data._response}");
            }
            Console.WriteLine($"{_name}");
        }
        //Save Section
        public void Save()
        {
            //Desire what file want to save - (FileName).txt or (File Name).csv
            Console.WriteLine("What is the name of the file? (.txt)or(.csv)");
                Console.Write("> ");
                    _name = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(_name))
            {
                foreach (_UserEntry data in _entries)
                {   
                    //List data stored
                    outputFile.WriteLine($"{data._date}~{data._entryPrompt}~{data._response}");
                }

            }
        }
        //Load Section
        public void Load()
        {
            //System.IO inport
            string[] lines = System.IO.File.ReadAllLines(_name);
                //Using List Type
                foreach (string line in lines)
                {
                    //Array
                    _UserEntry currentEntry = new _UserEntry();
                        string[] parts = line.Split("~");
                        //Data
                            currentEntry._date = parts[0];
                                //User Entry 
                                currentEntry._entryPrompt = parts[1];
                                    //User response
                                    currentEntry._response = parts[2];
                                        //Currently Entry Add
                                        _entries.Add(currentEntry);
                }
            //Calling the Public Void
            Display();

        }

    }
    //User Entry Format
    public class _UserEntry
    {
        public string _response;
            public string _entryPrompt;
                public string _date;
    }

}