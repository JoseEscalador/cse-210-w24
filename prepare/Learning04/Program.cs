using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment newAssignment = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(newAssignment.GetSummary());

        MathAssignment newMath = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(newMath.GetSummary());
        Console.WriteLine(newMath.GetHomeWork());
        WritingAssigment newWriting = new WritingAssigment("Mary Waters", "European History", "The Causes of World War");
        Console.WriteLine(newWriting.GetSummary());
        Console.WriteLine(newWriting.GetWritingInformation());
    }
}