using System;

class Program
{
    static void Main(string[] args)
    {
        string outTitle = "Picnic in the Park";
        string lecTitle = "Artificial Intelligence Lecture";
        string recTitle = "Makeup Line Launch Reception";

        Address outAddress = new Address("1024 Forest Avenue","Anytown","Anystate","USA");
        Address lecAddress = new Address("539 Camino De Los Andes","Córdoba","Córdoba","Argentina");
        Address recAddress = new Address("2045 Avenida General Sampaio","Salvador","Bahia","Brazil");

        string outDescription = "A casual picnic and birdwatching session in the park.";
        string lecDescription = "Dive into the latest advancements in artificial intelligence and their real-world implications.";
        string recDescription = "Join us for a reception celebrating the successful launch of our new product line.";

        string outDate = "03/15/2024";
        string lecDate = "04/10/2024";
        string recDate = "05/20/2024";

        string outTime = "12:00 PM";
        string lecTime = "3:30 PM";
        string recTime = "7:00 PM";

        string weather = "Expect sunny weather with a chance of scattered clouds";
        string email = "eventrsvp@events.com";
        string speaker = "Fulano de Tal";
        string capacity = "150";

        OutdoorGathering newOut = new OutdoorGathering(outTitle, outDescription, outDate, outTime, outAddress, weather);
        Lecture newLec = new Lecture(lecTitle, lecDescription, lecDate, lecTime, lecAddress, speaker, capacity);
        Reception newRec = new Reception(recTitle, recDescription, recDate, recTime, recAddress, email);

        newOut.StandardDetails();
        newOut.FullDetails();
        newOut.ShortDescription();

        newLec.StandardDetails();
        newLec.FullDetails();
        newLec.ShortDescription();

        newRec.StandardDetails();
        newRec.FullDetails();
        newRec.ShortDescription();

    }
}