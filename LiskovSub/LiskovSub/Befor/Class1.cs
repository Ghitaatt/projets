using System;

public class Bird
{
    public virtual void Eat()
    {
        Console.WriteLine("Bird eating...");
    }

    public virtual void Fly()
    {
        Console.WriteLine("Bird flying...");
    }
}

public class Penguin : Bird
{
    public override void Eat()
    {
        Console.WriteLine("Penguin eating...");
    }

    // Penguins cannot fly, but we need to override the fly method anyway
    public override void Fly()
    {
        Console.WriteLine("Penguins cannot fly!");
    }
}

public class Eagle : Bird
{
    public override void Eat()
    {
        Console.WriteLine("Eagle eating...");
    }

    public override void Fly()
    {
        Console.WriteLine("Eagle flying...");
    }
}

/*class Befor
{
    static void Main(string[] args)
    {
        Bird penguin = new Penguin();
        penguin.Eat();
        penguin.Fly(); // This will print "Penguins cannot fly!"

        Bird eagle = new Eagle();
        eagle.Eat();
        eagle.Fly(); // This will print "Eagle flying..."
        Console.ReadKey();
    }
}*/


