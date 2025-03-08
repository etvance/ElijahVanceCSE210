using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square shape1 = new Square("Purple", 4);
        shapes.Add(shape1);

        Rectangle shape2 = new Rectangle("Yellow", 5, 3);
        shapes.Add(shape2);

        Circle shape3 = new Circle("White", 7);
        shapes.Add(shape3);

        foreach (Shape x in shapes)
        {
            string color = x.GetColor();
            double area = x.GetArea();
            System.Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }

}