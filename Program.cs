namespace Teamappen;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("=== Suvnetappen ===");
        Console.WriteLine("Nu skall det bli coda av!");
        Console.WriteLine();

        Team.PrintMembers();
        Console.WriteLine();

        Console.WriteLine($"Dagens citat: {Quotes.GetQuote()}");
    }
}