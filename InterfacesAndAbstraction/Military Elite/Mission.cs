using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite
{
    public class Mission
    {
        private string codeName;
        private string state; //inProgress Finished

        public Mission(string codename, string state)
        {
            this.CodeName = codename;
            this.State = state;
        }

        public void CompleteMission()
        {
            this.State = "Finished";
        }

        public string CodeName
        {
            get => codeName;
            set => codeName = value;
        }
        public string State
        {
            get => state;
            set => state = value;
        }
        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.State}";
        }
    }
}
