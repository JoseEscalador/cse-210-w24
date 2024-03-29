public class Event {
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event (string title, string description, string date, string time, Address address) {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void StandardDetails() {
        Console.WriteLine("\n------ Standard Details ------");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"\nDate and time: {_date} - {_time}");
        Console.WriteLine($"\nAddress: {_address.GetAddress()}");
    }

}