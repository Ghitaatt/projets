using System;

class ReportGenerator
{
    public string GenerateReport(string data)
    {
        // Generating the report
        return $"Generating report with dataa: {data}";
    }
}

class ReportPrinter
{
    public void PrintReport(string report)
    {
        // Printing the report
        Console.WriteLine($"Printing report: {report}");
        Console.ReadKey();
    }
}


class Before
{
    static void Main()
    {
        ReportGenerator reportGenerator = new ReportGenerator();
        string generatedReport = reportGenerator.GenerateReport("Sample data");

        ReportPrinter reportPrinter = new ReportPrinter();
        reportPrinter.PrintReport(generatedReport);
        Console.ReadKey();
    }
}


