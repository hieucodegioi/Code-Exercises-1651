using ASM_1651;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        List<School> schools = new List<School>();

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

            Student student = new Student(id, details[1], dob);
            students.Add(student);
        }

        // Creating school and adding students
        School school = new School();
        foreach (Student student in students)
        {
            school.AddStudent(student);
        }
        schools.Add(school);

        // Printing all students
        Console.WriteLine("All Students:");
        foreach (Student student in school.GetAllStudents())
        {
            Console.WriteLine(student);
        }
    }
}