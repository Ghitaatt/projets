using System;

class Report
{
    public void GenerateReport(string data)
    {
        // Generating the report
        Console.WriteLine($"Generating report with data: {data}");
    }

    public void PrintReport(string report)
    {
        // Printing the report
        Console.WriteLine($"Printing report: {report}");
    }
}

/*class After
{
    static void Main()
    {
        Report report = new Report();
        report.GenerateReport("Sample data");
        report.PrintReport("Generated report");
        Console.ReadKey();
    }
}*/
