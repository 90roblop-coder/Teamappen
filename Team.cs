namespace Teamappen;

static class Team
{
    static List<string> members = new List<string>
    {
        "Robin"
    };

    public static void PrintMembers()
    {
        Console.WriteLine("Teammedlemmar:");
        foreach (string member in members)
        {
            Console.WriteLine($"- {member}");
        }
    }
}