public class ListingActivity : Activity {
    private int _count;
    private List<String> _prompts;
    public ListingActivity (string name, string description, List<String> prompts): base(name, description) {
        _prompts = prompts;
        _count = 0;
    }

    public void Run() {
        DisplayStartingMessage();
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(2);
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine();
        GetRandomPrompt();
        Console.WriteLine();

        Console.Write("You may begin in...");
        ShowSeconds(5);
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime) {
            List<String> list = new List<String>();
            Console.Write("> ");
            list.Add(Console.ReadLine());
            _count = _count +1;
        }
        Console.WriteLine();
        Console.WriteLine($"You listed {_count} itens");
        Console.WriteLine();
        Console.WriteLine("Well Done!");
        ShowSpinner(3);
        Console.WriteLine();
        DisplayEndingMessage();
        ShowSpinner(3);
    }

    public void GetRandomPrompt() {
        Random randomGen = new Random();
        int num = randomGen.Next(0, _prompts.Count());
        Console.WriteLine($" --- {_prompts[num]} ---");
    }
    
    public List<String> GetListFromUser() {
        List<String> list = new List<String>();
        return list;
        //Sorry but I didnt know what to do with this one.
    }

}