using System;
using System.Collections.ObjectModel;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> _shapes = new List<Shape>();
        Square square = new Square("red", 2);
        _shapes.Add(square);
        
        Rectangle rectangle = new Rectangle("blue", 2, 6);
        _shapes.Add(rectangle);
        
        Circle circle = new Circle("pink", 2);
        _shapes.Add(circle);

        foreach (Shape s in _shapes)
        {
            Console.WriteLine($"Shape Color: {square.GetColor()}, Area: {square.GetArea()}");
            Console.WriteLine($"Shape Color: {rectangle.GetColor()}, Area: {rectangle.GetArea()}");
            Console.WriteLine($"Shape Color: {circle.GetColor()}, Area: {circle.GetArea()}");
        }
    }


}
