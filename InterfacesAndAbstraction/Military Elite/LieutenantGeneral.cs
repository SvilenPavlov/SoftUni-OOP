using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite
{
    public class LieutenantGeneral : Private
    {
        private List<Private> privates;

        public LieutenantGeneral(string firstName, string lastName, int id, decimal salary, List<Private> privates):base(firstName,lastName,id,salary)
        {
            this.Privates = new List<Private>(privates);
        }

        public List<Private> Privates
        {
            get => privates;
            set => privates = value;
        }
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine +
                $"Privates:" + Environment.NewLine +
                "  " + string.Join(Environment.NewLine+"  ",this.Privates);
        }
    }
}
