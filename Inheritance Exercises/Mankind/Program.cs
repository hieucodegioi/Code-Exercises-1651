using Mankind;

internal class Program
{
    private static void Main(string[] args)
    {

        Student student = new Student();
        student.PrintInfo();
        


        /*try
        {
            string studentInfo = Console.ReadLine();
            string workerInfo = Console.ReadLine();

            string[] studentData = studentInfo.Split();
            string[] workerData = workerInfo.Split();

            Student student = new Student
            {
                FirstName = studentData[0],
                LastName = studentData[1],
                FacultyNumber = studentData[2]
            };

            Worker worker = new Worker
            {
                FirstName = workerData[0],
                LastName = workerData[1],
                WeekSalary = decimal.Parse(workerData[2]),
                WorkHoursPerDay = int.Parse(workerData[3])
            };

            student.PrintInfo();
            Console.WriteLine();
            worker.PrintInfo();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }*/
    }
}