using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite
{
    public class Private:Soldier
    {
        private decimal salary;

        public Private(string firstName, string lastName, int id, decimal salary) :base(firstName,lastName,id)
        {
            this.Salary = salary;
        }

        public decimal Salary
        {
            get => salary;
            set
            {
                salary = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $" Salary: {this.Salary:f2}";
        }
    }
}
