using System.Globalization;

public class BreathingActivity : Activity{
    public BreathingActivity (string name, string description): base(name, description) {
        _name = name;
        _description = description;
        _duration = 0;
    }

    public void Run() {
        DisplayStartingMessage();
        _duration = int.Parse(Console.ReadLine());
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(2);
        Console.WriteLine();
        while (DateTime.Now < endTime) {
            Console.Write("Breath in...");
            ShowSeconds(4);
            Console.WriteLine();
            Console.Write("Now breath out...");
            ShowSeconds(6);
            Console.WriteLine();
            Console.WriteLine();
        }
        ShowSpinner(3);
        Console.WriteLine("Well Done!");
        Console.WriteLine();
        DisplayEndingMessage();
        ShowSpinner(3);
    }
}