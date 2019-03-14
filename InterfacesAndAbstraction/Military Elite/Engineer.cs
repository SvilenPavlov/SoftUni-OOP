using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite
{
    public class Engineer : SpecialisedSoldier
    {
        private List<Repair> repairs;

        public Engineer(string firstName, string lastName, int id, decimal salary, string corps, List<Repair> repairs):base(firstName,lastName,id,salary,corps)
        {
            this.Repairs = new List<Repair>(repairs);
        }

        public List<Repair> Repairs
        {
            get => repairs;
            set => repairs = value;
        }
        public override string ToString()
        {
            if (this.repairs.Count != 0)
            {
                return base.ToString() + Environment.NewLine +
                    $"Corps: {this.Corps}" + Environment.NewLine +
                    $"Repairs:" + Environment.NewLine 
                    + "  " + string.Join(Environment.NewLine + "  ", this.Repairs);
            }
            else
            {
                return base.ToString() + Environment.NewLine +
                    $"Corps: {this.Corps}" + Environment.NewLine +
                    $"Repairs:";
            }
        }
    }
}
