internal class Program
{
    private static void Main(string[] args)
    {
        var l = int.Parse(Console.ReadLine());
        var w = int.Parse(Console.ReadLine());
        var h = int.Parse(Console.ReadLine());

        int surfaceArea = 2 * l * w + 2 * l * h + 2 * w * h;
        int lateSurfaceArea = 2 * l * h + 2 * w * h;
        int volume = l * w * h;

        Console.WriteLine("Surface Area - " + surfaceArea);
        Console.WriteLine("Lateral Surface Area - " + lateSurfaceArea);
        Console.WriteLine("Volume - " + volume);

    }
}