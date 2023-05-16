internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter the size of the rhombus: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        for (int i = n - 1; i >= 1; i--)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }


    }
}