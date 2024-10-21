using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Yellow", 5);
        shapes.Add(square);

        Rectangle rangle = new Rectangle("Blue", 4, 5);
        shapes.Add(rangle);

        Circle circle = new Circle("Green", 7);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}