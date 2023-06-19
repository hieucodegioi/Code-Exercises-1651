using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_1651
{
    internal class EmployeeManager
    {
        internal static int EnterEmployeeID()
        {
            Console.WriteLine("Enter ID of Employee");
            return int.Parse(Console.ReadLine());
        }

        public static int EnterEmployeePhoneNumber()
        {
            Console.WriteLine("Enter phonenumber of Employee");
            return int.Parse(Console.ReadLine());
        }

        internal static int EnterEmployeeAge()
        {
            Console.WriteLine("Enter Age of Employee");
            return int.Parse(Console.ReadLine());
        }

        internal static string EnterEmployeeAdress()
        {
            Console.WriteLine("Enter Adress of Employee");
            return Console.ReadLine();
        }

        internal static string EnterEmployeeName()
        {
            Console.WriteLine("Enter Name of Employee");
            return Console.ReadLine();
        }

        public static void Title()
        {
            Console.WriteLine();
            Console.WriteLine(".............Welcom to Employee Management System.............");
            Console.WriteLine("This is a program for employee management, thank you for using the application");
            Console.WriteLine();
        }

        internal static void MenuForLogin()
        {
            Console.WriteLine();
            Console.WriteLine("1. You are logged in as a company");
            Console.WriteLine("2. You are logged in as a employee");
            Console.WriteLine("3. Exit");
            Console.WriteLine();
        }

        internal static void MenuForCompany()
        {
            Console.WriteLine();
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Add Project");
            Console.WriteLine("3. View Employee");
            Console.WriteLine("4. View Project");
            Console.WriteLine("5. UpdateEmployeebyID");
            Console.WriteLine("6. UpdateProjectbyID");
            Console.WriteLine("7. DeleteEmployeeID");
            Console.WriteLine("8. DeleteProjectID");
            Console.WriteLine("9. SearchEmployeeByID");
            Console.WriteLine("10. SearchProjectByID");
            Console.WriteLine("11. Logout");
            Console.WriteLine();
            Console.WriteLine("Please choose your option");
        }

        internal static void AddSuccessful()
        {
            Console.WriteLine("Add Successful...");
        }

      
        internal static void UpdateFail()
        {
            Console.WriteLine("Update Fail");
        }

        internal static void UpdateSuccessful()
        {
            Console.WriteLine("Update Successful...");
        }

        internal static void MenuForEmployee()
        {
            Console.WriteLine();
            Console.WriteLine("1. View Employee");
            Console.WriteLine("2. View Project");
            Console.WriteLine("3. Search Employee");
            Console.WriteLine("4. Search Project");
            Console.WriteLine("5. Logout");
            Console.WriteLine();
            Console.WriteLine("Please choose your option");
        }

        internal static int EnterProjectID()
        {
            Console.Write("* Enter Project ID: ");
            return int.Parse(Console.ReadLine());
        }

        internal static string EnterNameProject()
        {
            Console.WriteLine("Enter Name of Project");
            return Console.ReadLine();
        }

        internal static string EnterDetailProject()
        {
            Console.WriteLine("Enter details of Project");
            return Console.ReadLine();
        }

        internal static void DeleteFail()
        {
            Console.WriteLine("Delete fail...");
            Console.WriteLine("Pls Try again...");
        }

        internal static void DeleteSuccessful()
        {
            Console.WriteLine("Delete Successful...");
        }

        internal static void SearchFail()
        {
            Console.WriteLine("Search Fail...\n Please try again...");
        }

        internal static void SearchSuccessful()
        {
            Console.WriteLine("Search Successful");
        }
        public static void IdAlreadyExist()
        {
            Console.WriteLine("Id Already Exist. Please Enter Another ID !!!");
        }
        public static string TypeExitToFinish()
        {
            Console.WriteLine("Type Exit to Finish Option!!!");
            return Console.ReadLine();
        }

    }
}
