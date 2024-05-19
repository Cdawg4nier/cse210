using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Green", 5.0);
        Console.WriteLine($"{square.GetArea()}, {square.GetColor()}");

        Rectangle rectangle = new Rectangle("Red", 5.0, 77.1);
        Console.WriteLine($"{rectangle.GetArea()}, {rectangle.GetColor()}");

        Circle circle = new Circle("Blue", 5.0);
        Console.WriteLine($"{circle.GetArea()}, {circle.GetColor()}");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetArea()}, {shape.GetColor()}");
        }
    }
}