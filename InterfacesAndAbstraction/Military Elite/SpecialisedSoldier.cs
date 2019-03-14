using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite
{
    public class SpecialisedSoldier : Private
    {
        private string corps;

        public SpecialisedSoldier(string firstName, string lastName, int id, decimal salary, string corps):base(firstName,lastName,id,salary)
        {
            this.Corps = corps;
        }

        public string Corps
        {
            get => corps;
            set
            {
                if (value != "Marines" && value != "Airforces")
                {
                    throw new ArgumentException();
                }
                    this.corps = value;
            }
        }
    }
}
