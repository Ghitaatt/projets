using System;

abstract class Shape
{
    public abstract double CalculateArea();
}

class Circle : Shape
{
    public double Radius { get; set; }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Square : Shape
{
    public double Side { get; set; }

    public override double CalculateArea()
    {
        return Side * Side;
    }
}

class After
{
    static void Main(string[] args)
    {
        Circle circle = new Circle { Radius = 5 };
        Console.WriteLine($"Area of Circle: {circle.CalculateArea()}");

        Square square = new Square { Side = 4 };
        Console.WriteLine($"Area of Square: {square.CalculateArea()}");
        Console.ReadKey();
    }
}


