using Association_3;

internal class Program
{
    private static void Main(string[] args)
    {
        Department department = new Department("IT Department");

        Room room1 = new Room("101");
        Room room2 = new Room("102");
        Room room3 = new Room("103");

        department.AddRoom(room1);
        department.AddRoom(room2);  
        department.AddRoom(room3);

        Console.WriteLine("Department: " + department.Name);
        Console.WriteLine("Rooms: ");
        foreach (var room in department.Rooms)
        {
            Console.WriteLine("Room number: " + room.Number);
        }
    }
}