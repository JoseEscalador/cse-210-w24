using System;


/*
DisplayWelcome - Displays the message, "Welcome to the Program!"
PromptUserName - Asks for and returns the user's name (as a string)
PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
DisplayResult - Accepts the user's name and the squared number and displays them.
*/

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome () 
        {
            Console.WriteLine("Welcome to the Program!");
        }
        

        static string PromptUserName ()
        {            
            Console.Write("Please enter your name: ");
            return Console.ReadLine();
        }
        static int PromptUserNumber () 
        {
            Console.Write("Please enter your favorite number: ");
            return int.Parse(Console.ReadLine());
        }
        static int SquareNumber (int number) {
            return number * number;
        }
        static void DisplayResult (string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(name, square);
    
    }
}