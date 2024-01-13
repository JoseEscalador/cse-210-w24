using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("What was your grade in percentage(just the numbers)? ");
        string answer = Console.ReadLine();
        int grade = int.Parse(answer);
        string letter = "";
        
        if (grade >= 90) 
        {
            letter = "A";
        }
        else if (grade >= 80) 
        {
            letter = "B";
        }
        else if (grade >= 70) 
        {
            letter = "C";
        }
        else if (grade >= 60) 
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine(letter);
        if (letter == "D" || letter == "F" )
        {
            Console.WriteLine($"Best of luck next time, you didn't pass. Don't be discouraged and keep trying!");
        }
        else
        {
            Console.WriteLine($"Cogratulations! You passed!");
        }    
    }
}