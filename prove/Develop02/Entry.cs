public class Entry {
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display(){
        //string prompt_line = $"Date: {_date} - Prompt: {_promptText}";
        //string 
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
    }
}