using System;

public interface IPrintere
{
    void Print();
}

public interface IScanner
{
    void Scan();
}



public class Printere : IPrintere, IScanner
{
    public void Print()
    {
        Console.WriteLine("Printing...");
    }

    public void Scan()
    {
        Console.WriteLine("Scanning...");
    }

    
}

public class JustPrintPrintere : IPrintere
{
    public void Print()
    {
        Console.WriteLine("Printing...");
    }
}

/*class Program
{
    static void Main(string[] args)
    {
        IPrintere printere = new JustPrintPrintere();
        printere.Print();
    }
}*/

