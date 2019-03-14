using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite
{
    public class Soldier
    {
        private int id;
        private string lastName;
        private string firstName;

        public Soldier(string firstName, string lastName, int id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
            }
        }


        public string LastName
        {
            get { return lastName; }
            set
            {
                this.lastName = value;
            }
        }
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
            }
        }


        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.Id}";
        }




    }
}
