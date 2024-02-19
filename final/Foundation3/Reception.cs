public class Reception : Event {
    private string _email;

    public Reception (string title, string description, string date, string time, Address address, 
    string email): base(title, description, date, time, address) {
        _email = email;
    }   

    public void FullDetails () {
        Console.WriteLine($"Type of event: Reception");
        Console.WriteLine($"\nTitle: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"\nDate and time: {_date} - {_time}");
        Console.WriteLine($"Address: {_address.GetAddress()}");
        Console.WriteLine($"\nE-mail for RSVP: {_email}");
    }
}