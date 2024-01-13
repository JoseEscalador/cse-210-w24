using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers and type 0 when finished.");
        int number = 1;
        List<int> numbers = new List<int>(); 
        float total = 0;
        int maxNumber = 0;
        while (number != 0) 
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
            total = total + number;
            if (maxNumber < number){
                maxNumber = number;
            }
        }
        float avg = total /(numbers.Count - 1);
        Console.WriteLine($"The sum is {total}");
        
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is {maxNumber}");
        

    }
}