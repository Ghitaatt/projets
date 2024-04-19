using System;

public class Birde
{
    public virtual void Eat()
    {
        Console.WriteLine("Bird eating...");
    }
}

public class FlyingBird : Bird
{
    public override void Fly()
    {
        Console.WriteLine("Bride flyinge...");
    }
}

public class Penguine : Bird
{
    public override void Eat()
    {
        Console.WriteLine("Penguin eating...");
    }
}

public class Eaglee : FlyingBird
{
    public override void Eat()
    {
        Console.WriteLine("Eagle eating...");
    }

    public override void Fly()
    {
        Console.WriteLine("Eagle flyinge...");
    }
}

class After
{
    static void Main(string[] args)
    {
        Bird penguin = new Penguine();
        penguin.Eat();

        Bird eagle = new Eaglee();
        eagle.Eat();
        ((FlyingBird)eagle).Fly(); // Casting to FlyingBird to access Fly method
        Console.ReadKey();
    }
}