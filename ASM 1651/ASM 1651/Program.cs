using ASM_1651;
using System.Drawing;

internal class Program
{
    private static Company company = new Company();
    private static Employee employee = new Employee();

    private static char isEndApp;

    static void Main(string[] args)
    {
        do
        {


            EmployeeManager.Title();
        MenuCommand:
            EmployeeManager.MenuForLogin();
            try
            {
                int optionForLogin = int.Parse(Console.ReadLine());
                do
                {
                    switch (optionForLogin)
                    {
                        case 1:
                            do
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Company Login");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("Enter Username of Company: ");
                                string EnterUserName = Console.ReadLine();  
                                Console.Write("Enter Password of Company: ");
                                string EnterPassword = Console.ReadLine();
                                if (company.Login(EnterUserName, EnterPassword))
                                {
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Login Successfully");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    EmployeeManager.MenuForCompany();
                                    do
                                    {
                                        int optionForMenuCompany = int.Parse(Console.ReadLine());
                                        switch (optionForMenuCompany)
                                        {
                                            case 1:

                                                // Add Employee
                                                company.AddInformationEmployee();
                                                EmployeeManager.AddSuccessful();
                                                EmployeeManager.MenuForCompany();
                                                break;

                                            case 2:
                                                // Add Project
                                                try
                                                {
                                                    // Not genarate ID
                                                    Console.WriteLine("Enter Project ID: ");
                                                    int projectID = int.Parse(Console.ReadLine());

                                                    // Enter Employee ID
                                                    Employee newEmployee = new Employee();
                                                    newEmployee.ID = EmployeeManager.EnterEmployeeID();

                                                    while (!company.SearchEmployeeID(newEmployee.ID))
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine("Employee ID not Exist. Please Enter Employee ID again");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        newEmployee.ID = EmployeeManager.EnterEmployeeID();
                                                    }

                                                    Employee employeeObj = company.SearchEmployeeObj(newEmployee.ID);


                                                    // Enter the rest of info

                                                    Console.WriteLine("Enter name project: ");
                                                    string namePro = Console.ReadLine();
                                                    Console.WriteLine("Enter details of project: ");
                                                    string details  = Console.ReadLine();
                                                    Project newProject = new Project(projectID, employeeObj, namePro, details);


                                                    // Add new project to project list in employee
                                                    company.Projects.Add(newProject);
                                                    EmployeeManager.AddSuccessful();
                                                    EmployeeManager.MenuForCompany();

                                                }
                                                catch (FormatException ex)
                                                {
                                                    Console.WriteLine("Please enter the number\n" + ex.Message);
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine("Error " + ex.Message);
                                                }
                                                break;

                                            case 3:
                                                // View Employee
                                                company.PrintInformationOfEmployee();
                                                EmployeeManager.MenuForCompany();
                                                break;


                                            case 4:
                                                // View Project
                                                company.PrintInformationOfProject();
                                                EmployeeManager.MenuForCompany();
                                                break;

                                            case 5:
                                                //Update Employee
                                                try
                                                {
                                                    int idEmployeeToUpdate = EmployeeManager.EnterEmployeeID();

                                                    while (!company.SearchEmployeeID(idEmployeeToUpdate))
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        EmployeeManager.UpdateFail();
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        idEmployeeToUpdate = EmployeeManager.EnterEmployeeID();
                                                    }

                                                    string NewName = EmployeeManager.EnterEmployeeName();
                                                    int NewAge = EmployeeManager.EnterEmployeeAge();
                                                    string NewAddress = EmployeeManager.EnterEmployeeAdress();
                                                    int NewPhone = EmployeeManager.EnterEmployeePhoneNumber();

                                                    company.UpdateEmployeeByID(idEmployeeToUpdate, NewName, NewAge, NewAddress, NewPhone);
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    EmployeeManager.UpdateSuccessful();
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    EmployeeManager.MenuForEmployee();
                                                }
                                                catch (FormatException ex)
                                                {
                                                    Console.WriteLine("Please enter the number\n" + ex.Message);
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine("Error " + ex.Message);
                                                }
                                                break;


                                            case 6:
                                                // Update Project
                                                try
                                                {
                                                    int idProjectToUpdate = EmployeeManager.EnterProjectID();
                                                    while (!company.SearchProjectID(idProjectToUpdate))
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        EmployeeManager.UpdateFail();
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        idProjectToUpdate = EmployeeManager.EnterProjectID();
                                                    }
                                                    
                                                    string NewNamePro = EmployeeManager.EnterNameProject();

                                                    string NewDetails = EmployeeManager.EnterDetailProject();
                                                    
                                                    company.UpdateProjectByID(idProjectToUpdate,  NewNamePro, NewDetails);
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    EmployeeManager.UpdateSuccessful();
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    EmployeeManager.MenuForCompany();
                                                }
                                                catch (FormatException ex)
                                                {
                                                    Console.WriteLine("Please enter t\n" + ex.Message);
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine("Error " + ex.Message);
                                                }
                                                break;
                                            case 7:
                                                // Delete Employee
                                                try
                                                {
                                                    int idToDelete = EmployeeManager.EnterEmployeeID();
                                                    while (!company.SearchEmployeeID(idToDelete))
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        EmployeeManager.DeleteFail();
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        idToDelete = EmployeeManager.EnterEmployeeID();
                                                    }
                                                    company.DeleteEmployeeByID(idToDelete);
                                                    
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    EmployeeManager.DeleteSuccessful();
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    EmployeeManager.MenuForCompany();
                                                }
                                                catch (FormatException ex)
                                                {
                                                    Console.WriteLine("Please enter again\n" + ex.Message);
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine("Error " + ex.Message);
                                                }
                                                break;
                                            case 8:
                                                // Delete Project
                                                try
                                                {
                                                    int idToDelete = EmployeeManager.EnterProjectID();
                                                    while (!company.SearchProjectID(idToDelete))
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        EmployeeManager.DeleteFail();
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        idToDelete = EmployeeManager.EnterProjectID();
                                                    }
                                                    company.DeleteProjectByID(idToDelete);
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    EmployeeManager.DeleteSuccessful();
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    EmployeeManager.MenuForCompany();
                                                }
                                                catch (FormatException ex)
                                                {
                                                    Console.WriteLine("Please enter again\n" + ex.Message);
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine("Error " + ex.Message);
                                                }
                                                break;
                                            case 9:
                                                //Search Employee
                                                try
                                                {
                                                    int enterID = EmployeeManager.EnterEmployeeID();
                                                   
                                                    var employeeInListBorrow = company.GetEmployeeByID(enterID);
                                                    Console.WriteLine(employeeInListBorrow.ToString());
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    EmployeeManager.SearchSuccessful();
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    EmployeeManager.MenuForEmployee();
                                                }
                                                catch (FormatException ex)
                                                {
                                                    Console.WriteLine("Please enter the number\n" + ex.Message);
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine("Error " + ex.Message);
                                                }
                                                break;

                                            case 10:
                                                //Search Project
                                                try
                                                {
                                                    int enterprojectID = EmployeeManager.EnterEmployeeID();
                                                    
                                                    var projectInListBorrow = company.GetProjectByID(enterprojectID);
                                                    Console.WriteLine(projectInListBorrow.ToString());
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    EmployeeManager.SearchSuccessful();
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    EmployeeManager.MenuForCompany();
                                                }
                                                catch (FormatException ex)
                                                {
                                                    Console.WriteLine("Please enter agian\n" + ex.Message);
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine("Error " + ex.Message);
                                                }
                                                break;

                                            case 11:
                                                goto MenuCommand;
                                        }
                                    } while (true);
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Login Fail\n Please Login again...");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    EmployeeManager.MenuForLogin();
                                }
                            }
                            while (optionForLogin != 3);
                            break;
                        case 2:
                            do
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Employee Login");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("Enter Username of Employee: ");
                                string EnterUserName = Console.ReadLine();
                                Console.Write("Enter Password of Employee: ");
                                string EnterPassword = Console.ReadLine();
                                employee.Login(EnterUserName, EnterPassword);
                                if (employee.Login(EnterUserName, EnterPassword))
                                {
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Login Successfully");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    EmployeeManager.MenuForEmployee();
                                    do
                                    {
                                        int optionForMenuEmployee = int.Parse(Console.ReadLine());
                                        switch (optionForMenuEmployee)
                                        {
                                            case 1:
                                                //View Employee
                                                company.PrintInformationOfEmployee();
                                                EmployeeManager.MenuForEmployee();
                                                break;

                                            case 2:
                                                // View Project
                                                company.PrintInformationOfProject();
                                                EmployeeManager.MenuForEmployee();
                                                break;
                                            case 3:
                                                //Search Employee
                                                try
                                                {
                                                    int enterID = EmployeeManager.EnterEmployeeID();
                                                    while (!company.SearchEmployeeID(enterID))
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        EmployeeManager.SearchFail();
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        enterID = EmployeeManager.EnterProjectID();
                                                    }
                                                    var employeeInListBorrow = company.GetEmployeeByID(enterID);
                                                    Console.WriteLine(employeeInListBorrow.ToString());
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    EmployeeManager.SearchSuccessful();
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    EmployeeManager.MenuForEmployee();
                                                }
                                                catch (FormatException ex)
                                                {
                                                    Console.WriteLine("Please enter the number\n" + ex.Message);
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine("Error " + ex.Message);
                                                }
                                                break;
                                            case 4:
                                                //Search project
                                                try
                                                {
                                                    int enterprojectID = EmployeeManager.EnterEmployeeID();
                                                    while (!company.SearchEmployeeID(enterprojectID))
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        EmployeeManager.SearchFail();
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        enterprojectID = EmployeeManager.EnterProjectID();
                                                    }
                                                    var projectInListBorrow = company.GetProjectByID(enterprojectID);
                                                    Console.WriteLine(projectInListBorrow.ToString());
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    EmployeeManager.SearchSuccessful();
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    EmployeeManager.MenuForEmployee();
                                                }
                                                catch (FormatException ex)
                                                {
                                                    Console.WriteLine("Please enter the number\n" + ex.Message);
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine("Error " + ex.Message);
                                                }
                                                break;
                                            case 5:
                                                goto MenuCommand;
                                        }
                                    }
                                    while (true);
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Login Fail\nPlease try again");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    EmployeeManager.MenuForLogin();
                                }
                            }
                            while (optionForLogin != 3);
                            break;
                        case 3:
                            Console.WriteLine("Thank you for using Empoyee Management");
                            break;
                    }
                }
                while (optionForLogin < 3);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter the number\n" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
            Console.ReadLine();
            Console.WriteLine("Enter Y TO continue and N to stop");
            isEndApp = char.Parse(Console.ReadLine());
        } while (isEndApp == 'Y' || isEndApp == 'y');
        Console.WriteLine("Goood Bye!!!");
    }
}