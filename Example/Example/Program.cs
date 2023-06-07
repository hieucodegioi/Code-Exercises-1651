using Association;

internal class Program
{
    private static void Main(string[] args)
    {
        Address add1 = new Address("227/1", " Nguyen Van Thoai", " Da Nang");
        Person person = new Person("Duong Van Hieu", add1);
        person.Display();
        Console.ReadLine();
    }
}