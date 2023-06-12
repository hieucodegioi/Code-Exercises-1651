using ASM_1651;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Employee> students = new List<Employee>();
        List<Company> schools = new List<Company>();

        // Adding students from user input
        while (true)
        {
            Console.WriteLine("Enter student details (ID, Name, Date of Birth) or 'q' to quit:");
            string input = Console.ReadLine();

            if (input == "q")
                break;

            string[] details = input.Split(',');

            if (details.Length != 3)
            {
                Console.WriteLine("Invalid input. Please try again.");
                continue;
            }

            if (!int.TryParse(details[0], out int id) || !DateTime.TryParse(details[2], out DateTime dob))
            {
                Console.WriteLine("Invalid input. Please try again.");
                continue;
            }

            Employee student = new Student(id, details[1], dob);
            students.Add(student);
        }

        // Creating school and adding students
        Company school = new Company();
        foreach (Employee student in students)
        {
            school.AddStudent(student);
        }
        schools.Add(school);

        // Printing all students
        Console.WriteLine("All Students:");
        foreach (Employee student in school.GetAllStudents())
        {
            Console.WriteLine(student);
        }
    }
}