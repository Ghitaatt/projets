using System;

class Shapei
{
    public virtual double Area()
    {
        throw new NotImplementedException();

    }
}

class Circlei : Shapei
{
    public double Radius { get; set; }

    // Bad: Violates OCP, modifying Shape class for new shapes
    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
}

class Squarei : Shapei
{
    public double Side { get; set; }

    // Bad: Violates OCP, modifying Shape class for new shapes
    public override double Area()
    {
        return Side * Side;
    }
}

/*class Before 
{
    static void Main(string[] args)
    {
        Circlei circle = new Circlei { Radius = 5 };
        Console.WriteLine($"Area of Circle: {circle.Area()}");

        Squarei square = new Squarei { Side = 4 };
        Console.WriteLine($"Area of Square: {square.Area()}");
    }
}*/
