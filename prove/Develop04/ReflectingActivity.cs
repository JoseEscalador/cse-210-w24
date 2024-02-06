using System.Diagnostics.CodeAnalysis;

public class ReflectingActivity : Activity {
    private List<String> _prompts;
    private List<String> _questions;

    public ReflectingActivity (string name, string description, List<String> prompts, List<String> questions) : base(name, description) {
        _name = name;
        _description = description;
        _duration = 0;
        _prompts = prompts;
        _questions = questions;
    }

    public void Run() {
        DisplayStartingMessage();
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(2);
        DisplayPrompt();
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in...");
        ShowSeconds(4);
        Console.Clear();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime) {
            DisplayQuestion();
        }
        Console.WriteLine();
        Console.WriteLine("Well Done!");
        ShowSpinner(3);
        Console.WriteLine();
        DisplayEndingMessage();
        ShowSpinner(3);
    }

    public string GetRandomPrompt() {
        Random randomGen = new Random();
        int num = randomGen.Next(0, _prompts.Count());
        return _prompts[num];
    }

    public string GetRandomQuestion() {
        Random randomGen = new Random();
        int num = randomGen.Next(0, _questions.Count());
        return _questions[num];
    }

    public void DisplayPrompt() {        
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.WriteLine();
        Console.Write("When you have something in mind press enter to continue.");
    }

    public void DisplayQuestion() {
        Console.Write($" > {GetRandomQuestion()} ");
        ShowSpinner(7);
        Console.WriteLine();
    }
}