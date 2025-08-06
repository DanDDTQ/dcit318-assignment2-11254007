// See https://aka.ms/new-console-template for more information
using System;

namespace AbstractShape;

class Program
{
    static void Main()
    {
        Shape circle = new Circle(7);
        Shape rectangle = new Rectangle(3, 5);

        Console.WriteLine($"Area of Circle: {circle.GetArea():F2} squarecm");
        Console.WriteLine($"Area of Rectangle: {rectangle.GetArea():F2} squarecm");
    }
}
