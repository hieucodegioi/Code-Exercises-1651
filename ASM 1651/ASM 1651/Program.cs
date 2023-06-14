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


            UICode.Title();
        MenuCommand:
            UICode.MenuForLogin();
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
                                Console.WriteLine("Company-Login-----------");
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
                                    UICode.MenuForCompany();
                                    do
                                    {
                                        int optionForMenuCompany = int.Parse(Console.ReadLine());
                                        switch (optionForMenuCompany)
                                        {
                                            case 1:

                                                // Add Employee
                                                company.AddInformationEmployee();
                                                UICode.AddSuccessful();
                                                UICode.MenuForCompany();
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
                                                    newEmployee.ID = UICode.EnterEmployeeID();

                                                    while (!company.SearchEmployeeID(newEmployee.ID))
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine("Employee ID not Exist. Please Enter Employee ID again");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        newEmployee.ID = UICode.EnterEmployeeID();
                                                    }

                                                    Employee employeeObj = company.SearchEmployeeObj(newEmployee.ID);


                                                    // Enter the rest of info

                                                    Console.WriteLine("Enter name project: ");
                                                    string namePro = Console.ReadLine();
                                                    Console.WriteLine("Enter details of project: ");
                                                    string details  = Console.ReadLine();
                                                    Project newPoint = new Project(projectID, employeeObj, namePro, details);


                                                    // Add new point to point list in employee
                                                    company.Projects.Add(newPoint);
                                                    UICode.AddSuccessful();
                                                    UICode.MenuForCompany();

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
                                                UICode.MenuForCompany();
                                                break;


                                            case 4:
                                                // View Project
                                                company.PrintInformationOfProject();
                                                UICode.MenuForCompany();
                                                break;

                                            case 5:
                                                //Update Employee
                                                try
                                                {
                                                    int idEmployeeToUpdate = UICode.EnterEmployeeID();

                                                    while (!company.SearchEmployeeID(idEmployeeToUpdate))
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        UICode.UpdateFail();
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        idEmployeeToUpdate = UICode.EnterEmployeeID();
                                                    }

                                                    string NewName = UICode.EnterEmployeeName();
                                                    int NewAge = UICode.EnterEmployeeAge();
                                                    string NewAddress = UICode.EnterEmployeeAdress();
                                                    int NewPhone = UICode.EnterEmployeePhoneNumber();

                                                    company.UpdateEmployeeByID(idEmployeeToUpdate, NewName, NewAge, NewAddress, NewPhone);
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    UICode.UpdateSuccessful();
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    UICode.MenuForEmployee();
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
                                                    int idProjectToUpdate = UICode.EnterProjectID();
                                                    while (!company.SearchProjectID(idProjectToUpdate))
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        UICode.UpdateFail();
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        idProjectToUpdate = UICode.EnterProjectID();
                                                    }
                                                    
                                                    string NewNamePro = UICode.EnterNameProject();

                                                    string NewDetails = UICode.EnterDetailProject();
                                                    
                                                    company.UpdateProjectByID(idProjectToUpdate,  NewNamePro, NewDetails);
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    UICode.UpdateSuccessful();
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    UICode.MenuForCompany();
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
                                                    int idToDelete = UICode.EnterEmployeeID();
                                                    while (!company.SearchEmployeeID(idToDelete))
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        UICode.DeleteFail();
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        idToDelete = UICode.EnterEmployeeID();
                                                    }
                                                    company.SearchEmployeeID(idToDelete);
                                                    company.DeleteProjectByID(idToDelete);
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    UICode.DeleteSuccessful();
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    UICode.MenuForCompany();
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
                                                // Delete Point
                                                try
                                                {
                                                    int idToDelete = UICode.EnterProjectID();
                                                    while (!company.SearchProjectID(idToDelete))
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        UICode.DeleteFail();
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        idToDelete = UICode.EnterProjectID();
                                                    }
                                                    company.DeleteProjectByID(idToDelete);
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    UICode.DeleteSuccessful();
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    UICode.MenuForCompany();
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
                                                    int enterID = UICode.EnterEmployeeID();
                                                    while (!company.SearchEmployeeID(enterID))
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        UICode.SearchFail();
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        enterID = UICode.EnterProjectID();
                                                    }
                                                    var employeeInListBorrow = company.GetEmployeeByID(enterID);
                                                    Console.WriteLine(employeeInListBorrow.ToString());
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    UICode.SearchSuccessful();
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    UICode.MenuForEmployee();
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
                                                    int enterprojectID = UICode.EnterEmployeeID();
                                                    while (!company.SearchEmployeeID(enterprojectID))
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Blue;
                                                        UICode.SearchFail();
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        enterprojectID = UICode.EnterProjectID();
                                                    }
                                                    var pointInListBorrow = company.GetProjectByID(enterprojectID);
                                                    Console.WriteLine(pointInListBorrow.ToString());
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    UICode.SearchSuccessful();
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    UICode.MenuForCompany();
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
                                    Console.WriteLine("Login Fail");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    UICode.MenuForLogin();
                                }
                            }
                            while (optionForLogin != 3);
                            break;
                        case 2:
                            do
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Employee-Login-----------");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("Enter Username of Employee: ");
                                string EnterUserName = Console.ReadLine();
                                Console.Write("Enter Password of Employee: ");
                                string EnterPassword = Console.ReadLine();
                                company.Login(EnterUserName, EnterPassword);
                                if (company.Login(EnterUserName, EnterPassword))
                                {
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Login Successfully");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    UICode.MenuForCompany();
                                    do
                                    {
                                        int optionForMenuEmployee = int.Parse(Console.ReadLine());
                                        switch (optionForMenuEmployee)
                                        {
                                            case 1:
                                                //View Employee
                                                company.PrintInformationOfEmployee();
                                                UICode.MenuForEmployee();
                                                break;

                                            case 2:
                                                // View Project
                                                company.PrintInformationOfProject();
                                                UICode.MenuForEmployee();
                                                break;
                                            case 3:
                                                //Search Employee
                                                try
                                                {
                                                    int enterID = UICode.EnterEmployeeID();
                                                    while (!company.SearchEmployeeID(enterID))
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        UICode.SearchFail();
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        enterID = UICode.EnterProjectID();
                                                    }
                                                    var employeeInListBorrow = company.GetEmployeeByID(enterID);
                                                    Console.WriteLine(employeeInListBorrow.ToString());
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    UICode.SearchSuccessful();
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    UICode.MenuForEmployee();
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
                                                //Search Point
                                                try
                                                {
                                                    int enterpointID = UICode.EnterEmployeeID();
                                                    while (!company.SearchEmployeeID(enterpointID))
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        UICode.SearchFail();
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        enterpointID = UICode.EnterProjectID();
                                                    }
                                                    var pointInListBorrow = company.GetProjectByID(enterpointID);
                                                    Console.WriteLine(pointInListBorrow.ToString());
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    UICode.SearchSuccessful();
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    UICode.MenuForEmployee();
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
                                    Console.WriteLine("Login Fail");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    UICode.MenuForLogin();
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