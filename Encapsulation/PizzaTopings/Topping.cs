using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private const int baseCalsperGram = 2;
        private const int maxWeight = 50;
        private const int minWeight = 1;
        private const string typeMeat = "meat";
        private const string typeVeggies = "veggies";
        private const string typeCheese = "cheese";
        private const string typeSauce = "sauce";

        private string type;
        private double weight;
        private double calsPerGram;

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;

            double typeMod = 0;
            string typeToLow = this.type.ToLower();
            switch (typeToLow)
            {
                case typeMeat:
                    typeMod = 1.2; break;
                case typeVeggies:
                    typeMod = 0.8; break;
                case typeCheese:
                    typeMod = 1.1; break;
                case typeSauce:
                    typeMod = 0.9; break;
            }

            this.CalsPerGram = baseCalsperGram * typeMod;
        }

        private string Type
        {
            get => type;
            set
            {
                string typeToLow = value.ToLower();
                if (typeToLow == typeMeat ||
                    typeToLow == typeVeggies ||
                    typeToLow == typeCheese ||
                    typeToLow == typeSauce)
                {
                    this.type = value;
                }
                else
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
            }
        }
        public double Weight //int
        {
            get => weight;
            private set
            {
                if (value >= minWeight && value <= maxWeight)
                {
                    this.weight = value;
                }
                else
                {
                    throw new ArgumentException($"{value} weight should be in the range [{minWeight}..{maxWeight}].");
                }
            }
        }
        public double CalsPerGram
        {
            get => calsPerGram;
            private set => calsPerGram = value;
        }
    }
}
