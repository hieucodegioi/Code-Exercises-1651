using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        public void AddProject(Project projects)
        {
            Projects.Add(projects);
        }
        public void AddInformationEmployee()
        {
            Employee newEmployee = new Employee();
            newEmployee.ID = EmployeeManager.EnterEmployeeID();
            newEmployee.InputInfor();
            employees.Add(newEmployee);

        }
        public void PrintInformationOfEmployee()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                   Company-List                   ");
            foreach (var employee in employees)
            {
                Console.WriteLine("Employee: "
                    + employee.ID
                    + employee.Name + " " + "Age"
                    + employee.Age + " " + "Adress:  "
                    + employee.Adress + " " + " PhoneNumber"
                    + employee.PhoneNumber);
            }

            Console.ForegroundColor = ConsoleColor.Blue;

        }
        public void PrintInformationOfProject()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("               Project-List               ");
            foreach (var project in Projects)
            {
                Console.WriteLine("Project ID: " + project.ProjectId +
                    " Employee Name: " + project.Employee.Name +
                    " Name of Project: " + project.NamePro +
                    " Details: " + project.Details);

            }

            Console.ForegroundColor = ConsoleColor.White;
        }

        
        public bool UpdateProjectByID(int idProjectToUpdate, string newNamePro, string newDetails)
        {
            var projectInList = Projects.FirstOrDefault(n => n.ProjectId.Equals(idProjectToUpdate));
            projectInList.NamePro = newNamePro;
            projectInList.Details = newDetails;
            
            return true;
        }
        public bool UpdateEmployeeByID(int idEmployeeToUpdate, string newName, int newAge, string newAddress, int newPhone)
        {
            var newStudent = employees.FirstOrDefault(n => n.ID.Equals(idEmployeeToUpdate));
            newStudent.Name = newName;
            newStudent.Age = newAge;
            newStudent.Adress = newAddress;
            newStudent.PhoneNumber = newPhone;

            Console.WriteLine("Update successfully");
            return true;
        }
        public bool DeleteProjectByID(int idProjectToDelete)
        {
            var projectInList = Projects.FirstOrDefault(n => n.ProjectId.Equals(idProjectToDelete));
            Projects.Remove(projectInList);
            return true;
        }
        public bool DeleteEmployeeByID(int idEmployeeToDelete)
        {
            var employeesInList = employees.FirstOrDefault(n => n.ID.Equals(idEmployeeToDelete));
            employees.Remove(employeesInList);
            return true;
        }



        public bool SearchEmployeeID(int idEmployeeToSearch)
        {
            var employeeInList = employees.FirstOrDefault(n => n.ID.Equals(idEmployeeToSearch));
            if (employeeInList == null)
            {
                return false;
            }
            return true;
        }

        public Employee SearchEmployeeObj(int idEmployeeToSearch)
        {
            var employeeInList = employees.FirstOrDefault(n => n.ID.Equals(idEmployeeToSearch));
            return employeeInList;
        }
        public Project SearchProjectObj(int idProjectToSearch)
        {
            var projectInList = Projects.FirstOrDefault(n => n.ProjectId.Equals(idProjectToSearch));
            return projectInList;
        }
        public bool SearchProjectID(int idProjectToSearch)
        {
            var projectInList = Projects.FirstOrDefault(n => n.ProjectId.Equals(idProjectToSearch));
            if (projectInList == null)
            {
                return false;
            }
            return true;
        }
        public Project GetProjectByID(int idProjectToSearch)
        {
            var projectInList = Projects.FirstOrDefault(x => x.ProjectId.Equals(idProjectToSearch));
            return projectInList;
        }
        public Employee GetEmployeeByID(int idEmployeeToSearch)
        {
            var employeeInList = employees.FirstOrDefault(x => x.ID.Equals(idEmployeeToSearch));
            return employeeInList;
        }
    }
}
