using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite
{
    public class Spy : Soldier
    {
        private int codeNumber;
        public Spy(string firstName, string lastName, int id, int codeNumber) : base(firstName, lastName, id)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber
        {
            get => codeNumber;
            set
            {
                //if (int.TryParse(value, out int a) == false)
                //{
                //    throw new ArgumentException();
                //}
                codeNumber = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine +
                $"Code Number: {this.CodeNumber}";
        }
    }
}
