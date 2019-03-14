using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Military_Elite
{
    public class Commando  : SpecialisedSoldier
    {
        private List<Mission> missions;
        public Commando(string firstName, string lastName, int id, decimal salary, string corps, List<Mission> missions):base(firstName,lastName,id,salary,corps)
        {
            this.Missions = new List<Mission>(missions);
        }

        public List<Mission> Missions
        {
            get => missions;
            set => missions = value;
        }
        public override string ToString()
        {
            if (this.missions.Count != 0)
            {
                return base.ToString() + Environment.NewLine +
                    $"Corps: {this.Corps}" + Environment.NewLine +
                    $"Missions:" + Environment.NewLine + "  " +
                    string.Join(Environment.NewLine + "  ", this.missions);
            }
            else
            {
                return base.ToString() + Environment.NewLine +
                    $"Corps: {this.Corps}" + Environment.NewLine +
                    $"Missions:";
            }
        }
    }
}
