namespace Teamappen;

static class Quotes
{
    static List<string> quotes = new List<string>
    {
        "Commit early, commit often.",
        "Det fungerar på min dator.",
        "Code Test Break Repeat"
    };

    public static string GetQuote()
    {
        Random random = new Random();
        return quotes[random.Next(quotes.Count)];
    }
}