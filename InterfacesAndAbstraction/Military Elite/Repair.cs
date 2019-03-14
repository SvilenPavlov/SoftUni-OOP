using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite
{
    public class Repair
    {
        private string partName;
        private int hoursWorked;

        public Repair(string partname, int hoursWorked)
        {
            this.Partname = partname;
            this.HoursWorked = hoursWorked;
        }

        public string Partname
        {
            get => partName;
            set => partName = value;
        }
        public int HoursWorked
        {
            get => hoursWorked;
            set => hoursWorked = value;
        }

        public override string ToString()
        {
            return $"Part Name: {this.Partname} Hours Worked: {this.HoursWorked}";
        }

    }
}
