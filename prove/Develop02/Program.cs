        // Entry thisEntry = new Entry();
        // thisEntry._date = today.ToString();
        // thisEntry._promptText = thisPrompt.GetRandomPrompt();
        // Console.WriteLine(thisEntry._promptText);
        // thisEntry._entryText = Console.ReadLine();
        // thisEntry.Display();

using System;



class Program
{

    static void Main(string[] args)
    {
        //Generating prompt class and populating prompt list
        PromptGenerator thisPrompt = new PromptGenerator();
        thisPrompt._prompts = new List<String>();
        thisPrompt._prompts.Add("Who was the most interesting person I interacted with today?");
        thisPrompt._prompts.Add("What was the best part of my day?");
        thisPrompt._prompts.Add("What was the strongest emotion I felt today?");
        thisPrompt._prompts.Add("If I had one thing I could do over today, what would it be?");
        thisPrompt._prompts.Add("How did I see the hand of the Lord in my life today?");
        
        

        Journal thisJournal = new Journal();
        thisJournal._entries = new List<Entry>();
        

        string _switch = "0";
        while (_switch != "5") {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do? ");
            _switch = Console.ReadLine();
            
            if (_switch == "1"){
                Entry thisEntry = new Entry();
                DateTime today = DateTime.Now;
                thisEntry._date = today.ToShortDateString();
                thisEntry._promptText = thisPrompt.GetRandomPrompt();
                Console.WriteLine(thisEntry._promptText);
                thisEntry._entryText = Console.ReadLine();
                thisJournal.AddEntry(thisEntry);
            } 

            else if (_switch == "2") {
                thisJournal.DisplayAll();
            }
            else if (_switch == "3") {
                Console.Write("What is the filename?");
                string file = Console.ReadLine();
                thisJournal._entries = new List<Entry>();
                thisJournal.LoadFromFile(file);
            }
            else if (_switch == "4") {
                Console.Write("What is the filename?");
                string file = Console.ReadLine();
                thisJournal.SaveToFile(file);
            }
            else if (_switch != "5"){
                Console.Write("This is not a valid value, try a value between 1 and 5");
            }
        }

    }
}