using Association_2;

internal class Program
{
    private static void Main(string[] args)
    {
        Student student = new Student("Duong Van", "Hieu");
        Teacher teacher = new Teacher("Pham Thanh", "Son", student);
        student.Teacher = teacher;
        student.Display();
        teacher.Display();
    }
}