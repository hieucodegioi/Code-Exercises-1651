using System;
using System.Collections.Generic;
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
            string usernameCorrect = "Student";
            string passwordCorrect = "Student";
            if (usernameToCheck == usernameCorrect && passwordToCheck == passwordCorrect)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Employee(int id, string name, DateTime dateOfBirth, string email) : this(id)
        {

        }
        public override void InputInfor()
        {
            this.Name = UICode.EnterStudentName();
            this.Email = UICode.EnterStudentEmail();
            this.DateOfBirth = UICode.EnterStudentDOB();
        }

        public override string? ToString()
        {
            return "Student ID:" + Id +
                " Name: " + Name + 
                " DateOfBirth: " + DateOfBirth + 
                " Email: " + Email;
        }

       
    }
}
