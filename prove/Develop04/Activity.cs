public class Activity {
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity (string name, string description) {
        _name = name;
        _description = description;
        _duration = 0;
    }
    public void DisplayStartingMessage() {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
    }
    public void DisplayEndingMessage() {
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
    }
    public void ShowSpinner (int seconds) {
        List<String> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        //animationStrings.Add("|");
        //animationStrings.Add("");
        int i = 0;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime) {
            Console.Write(animationStrings[i]);
            Thread.Sleep(500);
            Console.Write("\b \b");
            
            i++;
            if (i >= animationStrings.Count()){
                i = 0;
            }
        }
    }
    public void ShowSeconds (int seconds) {
        
        for(int i = seconds; i > 0; i--) {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

}