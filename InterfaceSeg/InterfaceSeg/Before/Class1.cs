using System;

public interface IPrinter
{
    void Print();
    void Scan();
    
}

public class Printer : IPrinter
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

public class JustPrintPrinter : IPrinter
{
    public void Print()
    {
        Console.WriteLine("Printing...");
    }

    // These methods are not relevant for JustPrintPrinter, but we are forced to implement them.
    public void Scan()
    {
        throw new NotImplementedException("JustPrintPrinter does not support scanning.");
    }
}

class Before
{
    static void Main(string[] args)
    {
        IPrinter printer = new JustPrintPrinter();
        printer.Print();
        Console.ReadKey();
    }
}
