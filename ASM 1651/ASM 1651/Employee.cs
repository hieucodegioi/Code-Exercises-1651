using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ASM_1651
{
    public class Employee : Person, ILogin
    {

        List<Project> points = new List<Project>();

        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public List<Project> Points { get => points; set => points = value; }

        public Employee(int id)
        {
            ID = id;
        }
        public Employee()
        {

        }

        public bool Login(string usernameToCheck, string passwordToCheck)
        {
            string usernameCorrect = "Employee";
            string passwordCorrect = "Employee";
            if (usernameToCheck == usernameCorrect && passwordToCheck == passwordCorrect)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Employee(int iD, string name, int age, string adress, int phoneNumber ) : this(iD)
        {
            
        }

        public override void InputInfor()
        {
            this.Name = EmployeeManager.EnterEmployeeName();
            this.Age = EmployeeManager.EnterEmployeeAge();
            this.Adress = EmployeeManager.EnterEmployeeAdress();
            this.PhoneNumber = EmployeeManager.EnterEmployeePhoneNumber();

        }

        public override string? ToString()
        {
            return " Name: " + Name + 
                " Age: " + Age + 
                " Adress: " + Adress +
                " Phone Number: " + PhoneNumber;
        }

       
    }
}
