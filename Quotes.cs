namespace Teamappen;

static class Quotes
{
    static List<string> quotes = new List<string>
    {
        "Commit early, commit often.",
        "Det fungerar på min dator.",
        "Code Test Break Repeat",
        "Git är bra att ha",
        "Du anar ugglor som får käder",
        "Kodning: 10 % skriva kod, 90 % undra varför koden inte fungerar."
    };

    public static string GetRandomQuote()
    {
        Random random = new Random();
        return quotes[random.Next(quotes.Count)];
    }
}