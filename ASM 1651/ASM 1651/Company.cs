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
        List<Project> projects = new List<Project>();

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public List<Project> Projects
        {
            get => projects; set => projects = value;
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
            newEmployee.InputInfor();
            employees.Add(newEmployee);

        }
        public void PrintInformationOfEmployee()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                   Company-List                   ");
            foreach (var employee in employees)
            {
                Console.WriteLine("Employee "
                    + employee.Name + " " + "Age"
                    + employee.Age + " " + "Adress:  "
                    + employee.Adress + " " + " PhoneNumber"
                    + employee.PhoneNumber);
            }

            Console.ForegroundColor = ConsoleColor.White;

        }
        public void PrintInformationOfProject()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("               Project-List               ");
            foreach (var project in projects)
            {
                Console.WriteLine("Project ID: " + project.ProjectId +
                    " Employee Name: " + project.Employee.Name +
                    " Name of Project: " + project.NamePro +
                    " Details: " + project.Details);

            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
