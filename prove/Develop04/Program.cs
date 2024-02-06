using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity newBA = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

        List<string> promptsList = new List<string>();
        promptsList.Add("Think of a time when you stood up for someone else.");
        promptsList.Add("Think of a time when you did something really difficult");
        promptsList.Add("Think of a time when you helped someone in need.");
        promptsList.Add("Think of a time when you did something truly selfless");        
    
        List<string> questionsList = new List<string>();
        questionsList.Add("Why was this experience meaningful to you?");
        questionsList.Add("Have you ever done anything like this before?");
        questionsList.Add("How did you get started?");
        questionsList.Add("How did you feel when it was complete?");
        questionsList.Add("What made this time different than other times when you were not as successful?");
        questionsList.Add("What is your favorite thing about this experience?");
        questionsList.Add("What could you learn from this experience that applies to other situations?");
        questionsList.Add("What did you learn about yourself through this experience?");
        questionsList.Add("How can you keep this experience in mind in the future?");

        ReflectingActivity newRA = new ReflectingActivity("Reflecting Activity", 
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life", promptsList, questionsList);

        List<string> promptsLA = new List<string>();
        promptsLA.Add("Who are people that you appreciate?");
        promptsLA.Add("What are personal strengths of yours?");
        promptsLA.Add("Who are people that you have helped this week?");
        promptsLA.Add("When have you felt the Holy Ghost this month?");
        promptsLA.Add("Who are some of your personal heroes?");

        ListingActivity newLA = new ListingActivity("Listing Activity", 
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 
        promptsLA);

        string choice = "0";
        while (choice != "4") {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine();
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.WriteLine();
            Console.Write("  Select a choice from the menu: ");
            choice = Console.ReadLine();
            if (choice == "1") {
                Console.Clear();
                newBA.Run();    
            }
            else if (choice == "2") {
                Console.Clear();
                newRA.Run();    
            }
            else if (choice == "3") {
                Console.Clear();
                newLA.Run();    
            }
            else {
                Console.WriteLine();
                Console.WriteLine("Not a valid response, try again.");
                Thread.Sleep(5000);
            }
        }
        
    
    }
}