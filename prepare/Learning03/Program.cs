using System;

class Program
{
    static void Main(string[] args){
        Fraction f = new Fraction();
        Fraction f1 = new Fraction(6);
        Fraction f2 = new Fraction(6, 7);
        Fraction f3 = new Fraction();
        f.setTop(1);
        f1.setTop(5);
        f2.setTop(3);
        f2.setBottom(4);
        f3.setTop(1);
        f3.setBottom(3);
        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(f.GetDecimalValue());
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        
    }
}