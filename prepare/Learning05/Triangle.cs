public class Triangle : Shape {
    private double _lenght;
    private double _width;

    public Triangle (string color, double lenght, double width) : base (color) {
        _color = color;
        _lenght = lenght;
        _width = width;
    }

    public override double GetArea()
    {
        return (_lenght*_width)/2;
    }
}