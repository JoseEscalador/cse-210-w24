using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Square s1 = new Square("Blue", 5.3);
        Square s2 = new Square("Red", 7.0);
        Square s3 = new Square("Green", 4.5);
        Square s4 = new Square("Yellow", 8.2);
        Square s5 = new Square("Purple", 6.1);
        
        Circle c1 = new Circle("Green", 10.4);
        Circle c2 = new Circle("Orange", 15.0);
        Circle c3 = new Circle("Pink", 6.7);
        Circle c4 = new Circle("Blue", 12.3);
        Circle c5 = new Circle("Brown", 8.9);
        
        Triangle t1 = new Triangle("Red", 10, 20.21);
        Triangle t2 = new Triangle("Yellow", 8, 15.0);
        Triangle t3 = new Triangle("Blue", 12, 25.5);
        Triangle t4 = new Triangle("Green", 6, 12.7);
        Triangle t5 = new Triangle("Purple", 15, 30.0);
    
        List<Shape> shapes = new List<Shape>();
        shapes.Add(s1);
        shapes.Add(c1);
        shapes.Add(t1);
        shapes.Add(s2);
        shapes.Add(c2);
        shapes.Add(t2);
        shapes.Add(s3);
        shapes.Add(c3);
        shapes.Add(t3);
        shapes.Add(s4);
        shapes.Add(c4);
        shapes.Add(t4);
        shapes.Add(s5);
        shapes.Add(c5);
        shapes.Add(t5);

        foreach (Shape shape in shapes) {
            Console.WriteLine($"Shape: {shape.GetType()} Color: {shape.GetColor()} Area: {shape.GetArea()}\n");
        }

    }
}