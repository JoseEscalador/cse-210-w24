using System;

class Program
{
    static void Main(string[] args)
    {

        Reference newRef = new Reference("1 Nephi", 3, 7);
        Scripture newScripture = new Scripture(newRef, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        Console.WriteLine(newScripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("Press enter to continue or write `quit` to quit");
        string _entry = Console.ReadLine();
        
        while (!newScripture.IsCompletelyHidden() && _entry != "quit"){
            Console.Clear();
            Random randomGen = new Random();
            int num = randomGen.Next(10, 12);
            newScripture.HideRandomWords(num);
            Console.WriteLine(newScripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or write `quit` to quit");
            _entry = Console.ReadLine();
        }
        
    }
}