using System;
using System.Collections.Generic;
using System.Text;

namespace Mankind
{
    public class Student:Human
    {
        private string facultyNumber;

        public Student(string firstName,string lastName, string facultyNumber) :base(firstName,lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        private string FacultyNumber
        {
            get => facultyNumber;
            set
            {
                
                if (value.Length<5 || value.Length>10)
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                if (CheckFacNum(value) == false)
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                this.facultyNumber = value;
            }
        }

        private bool CheckFacNum(string value)
        {

            foreach (var cha in value)
            {
                if (char.IsLetterOrDigit(cha)==false)
                {
                    return false;
                }
            }
            return true;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine +
                $"Faculty number: {this.FacultyNumber}" + Environment.NewLine;
        }
    }
}
