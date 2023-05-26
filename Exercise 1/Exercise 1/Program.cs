using Problem_5;

internal class Program
{
    private static void Main(string[] args)
    {
        DateModifier dateModifier = new DateModifier();

        string date1 = Console.ReadLine();
        string date2 = Console.ReadLine();

        int difference = dateModifier.CalculateDateDifference(date1, date2);
        Console.WriteLine(difference);
    }
}