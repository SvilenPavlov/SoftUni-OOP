using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private const int baseCalsperGram = 2;
        private const int maxWeight = 200;
        private const int minWeight = 1;
        private const string fTypeWhite = "white";
        private const string fTypeWholegrain = "wholegrain";
        private const string bTechCrispy = "crispy";
        private const string bTechChewy = "chewy";
        private const string bTechHomemade = "homemade";

        private string flourType; 
        private string bakingTechnique; 
        private double weight;
        private double calsPerGram;

        public Dough(string flourType,string bakingTechnique, int weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;

            double flourMod = 0;
            string flourToLow = this.flourType.ToLower();
            if (flourToLow == fTypeWhite)
            {
                flourMod = 1.5;
            }
            else if (flourToLow == fTypeWholegrain)
            {
                flourMod = 1;
            }
            double bakingMod = 0;
            string bakingToLow = bakingTechnique.ToLower();
            switch (bakingToLow)
            {
                case bTechCrispy:
                    bakingMod = 0.9;break;
                case bTechChewy:
                    bakingMod = 1.1;break;
                case bTechHomemade:
                    bakingMod = 1;break;
            }

            this.CalsPerGram = baseCalsperGram * flourMod * bakingMod;
        }

       
        public double CalsPerGram
        {
            get => calsPerGram;
            private set => calsPerGram = value;
        }

        private string FlourType
        {
            get => flourType;

            set
            {
                string flourToLow = value.ToLower();
                if (flourToLow == fTypeWhite || flourToLow == fTypeWholegrain)
                {
                    this.flourType = value;
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
            }
        }
        private string BakingTechnique
        {
            get => bakingTechnique;
            set
            {
                string techniqueToLow = value.ToLower();
                if (techniqueToLow == bTechCrispy || techniqueToLow == bTechChewy || techniqueToLow == bTechHomemade)
                {
                    this.bakingTechnique = value;
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
            }
        }
        public double Weight //int
        {
            get => weight;
            private set
            {
                if (value>=minWeight && value<=maxWeight)
                {
                    this.weight = value;
                }
                else
                {
                    throw new ArgumentException($"Dough weight " +
                        $"should be in the range [{minWeight}..{maxWeight}].");
                }
            }
        }
    }
}
