using System;
using System.Collections.Generic;
using System.Text;

namespace Mankind
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        private string FirstName
        {
            get => firstName;
            set
            {
                if (value.Length < 4)
                {
                    throw new ArgumentException($"Expected length at least 4 symbols! Argument: firstName");
                }
                if (char.IsUpper(value[0])==false)
                {
                    throw new ArgumentException($"Expected upper case letter! Argument: firstName");
                }
                
                this.firstName = value;
            }
        }
        private string LastName
        {
            get => lastName;
            set
            {
                if (char.IsUpper(value[0]) == false)
                {
                    throw new ArgumentException($"Expected upper case letter! Argument: lastName");
                }
                if (value.Length <= 3)
                {
                    throw new ArgumentException($"Expected length at least 3 symbols! Argument: lastName");
                }
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return $"First Name: {this.firstName}"+Environment.NewLine+
                   $"Last Name: {this.lastName}";
        }
    }
}
