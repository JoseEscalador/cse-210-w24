public class OutdoorGathering : Event {
    private string _weatherStatement;

    public OutdoorGathering (string title, string description, string date, string time, Address address,
    string weatherStatement): base(title, description, date, time, address) {
        _weatherStatement = weatherStatement;
    }   


    public void FullDetails () {
        Console.WriteLine($"Type of event: Outdoor Gathering");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"\nDate and time: {_date} - {_time}");
        Console.WriteLine($"Address: {_address.GetAddress()}");
        Console.WriteLine($"\nWeather Statement: {_weatherStatement}");
    }
}