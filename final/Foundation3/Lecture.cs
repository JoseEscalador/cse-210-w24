public class Lecture : Event {
    private string _speaker;
    private string _capacity;

    public Lecture (string title, string description, string date, string time, Address address,
    string speaker, string capacity) : base(title, description, date, time, address) {
        _speaker = speaker;
        _capacity = capacity;
    }

    public void FullDetails () {
        Console.WriteLine("\n------ Full Details ------");
        Console.WriteLine($"Type of event: Lecture");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"\nDate and time: {_date} - {_time}");
        Console.WriteLine($"Address: {_address.GetAddress()}");
        Console.WriteLine($"\nSpeaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}");
    }    

    public void ShortDescription() {
        Console.WriteLine("\n------ Short Description ------");
        Console.WriteLine($"Type of event: Lecture");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Date: {_date}");
    }
}