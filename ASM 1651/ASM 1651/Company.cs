using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_1651
{
    public class Company : ILogin
    {
        List<Employee> employees = new List<Employee>();
        List<Point> points = new List<Point>();

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public List<Point> Points
        {
            get => points; set => points = value;
        }


        public Company()
        {
            
        }
        public bool Login(string usernameToCheck, string passwordToCheck)
        {
            string usernameCorrect = "Company";
            string passwordCorrect = "Company";
            if (usernameToCheck == usernameCorrect && passwordToCheck == passwordCorrect)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void AddInformationEmployee()
        {
            Employee newEmployee = new Employee();
            newEmployee.Id = (int)UICode.EnterStudentID();
            newEmployee.InputInformation();
            employees.Add(newEmployee);

        }
        public void PrintInformationOfEmployee()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                   Company-List                   ");
            foreach (var employee in employees)
            {
                Console.WriteLine("Employee: " + employee.Id + " " + "Name: "
                    + employee.Name + " " + "Email:"
                    + employee.Email + " " + "Date Of Birth "
                    + employee.DateOfBirth);
            }

            Console.ForegroundColor = ConsoleColor.White;

        }
        public void PrintInformationOfProduct()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("               Product-List               ");
            foreach (var product in Points)
            {
                Console.WriteLine("Product:"+ product.Subject +
                    " StudentID:" + product.Student.Id +
                    " Student Name" + product.Student.Name +
                    " Score" + product.Valuee);

            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
