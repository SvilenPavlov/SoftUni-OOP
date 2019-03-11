using System;
using System.Collections.Generic;
using System.Text;

namespace Mankind
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private double workingHours;
        private decimal salaryPerHour;

        public Worker(string firstName, string lastName, decimal salary, double workingHours) : base(firstName, lastName)
        {
            this.WeekSalary = salary;
            this.WorkingHours = workingHours;
            this.salaryPerHour = this.weekSalary / (5m * (decimal)this.workingHours);
        }

        private decimal WeekSalary
        {
            get => weekSalary;
            set
            {
                if (value<=10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                this.weekSalary = value;
            }
        }
        private double WorkingHours
        {
            get => workingHours;
            set
            {
                if (value<1 || value>12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                this.workingHours = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine +
                $"Week Salary: {this.WeekSalary:f2}" + Environment.NewLine +
                $"Hours per day: {this.WorkingHours:f2}" + Environment.NewLine +
                $"Salary per hour: {this.salaryPerHour:f2}" ;
        }
    }
}
