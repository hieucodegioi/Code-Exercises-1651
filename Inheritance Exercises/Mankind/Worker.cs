using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mankind
{
    internal class Worker : Human
    {

        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay; 
        }

        public decimal WeekSalary { get {  return weekSalary; } 
            set 
            {
                if (value <= 10) 
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                this.weekSalary = value;
            } 
        }
        public int WorkHoursPerDay { get {  return workHoursPerDay; } 
            set 
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                workHoursPerDay = value; 
            }
        }
        public decimal CalculateSalaryPerHour()
        {
            return weekSalary / (workHoursPerDay * 5); 
        }
        public void PrintInfo()
        {
            Console.WriteLine($"First Name: {FirstName}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"Week Salary: {WeekSalary:F2}");
            Console.WriteLine($"Hours per day: {WorkHoursPerDay}");
            Console.WriteLine($"Salary per hour: {CalculateSalaryPerHour():F2}");
        }
    }
}
