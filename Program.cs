namespace Teamappen;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("=== Suvnetappen ===");
        Console.ResetColor();
        Console.WriteLine("Nu skall det bli coda av!");
        Console.WriteLine("Welcome!");
        Console.WriteLine();

        Team.PrintMembers();
        Console.WriteLine();

        Console.WriteLine($"Dagens citat: {Quotes.GetRandomQuote()}");
    }
}