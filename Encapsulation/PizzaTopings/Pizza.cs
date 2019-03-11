using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private const int minNameLen = 1;
        private const int maxNameLen = 15;
        private const int minToppings = 0;
        private const int maxToppings = 10;

        private string name;
        private Dough dough;
        private List<Topping> toppings;
        private double totalCals;

        public Pizza(string name, Dough dough, List<Topping> toppings)
        {
            this.Name = name;
            this.Dough = dough;
            this.Toppings = new List<Topping>(toppings);
            double doughCals = this.Dough.Weight * this.Dough.CalsPerGram;
            double toppingsCals = 0;
            foreach (var topping in this.Toppings)
            {
                toppingsCals += topping.Weight * topping.CalsPerGram;
            }
            this.TotalCals = doughCals + toppingsCals;
        }

        public string Name
        {
            get => name;
            private set
            {
                int nameLen = value.Length;
                if (string.IsNullOrWhiteSpace(value) == false &&
                    string.IsNullOrEmpty(value) == false &&
                    nameLen >= minNameLen &&
                    nameLen <= maxNameLen
                    )
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException($"Pizza name should be between {minNameLen} and {maxNameLen} symbols.");
                }
            }
        }
        public Dough Dough
        {
            private get => dough;
            set => dough = value;
        }
        public List<Topping> Toppings
        {
            get => toppings;
            set
            {
                int toppingCount = value.Count;
                if (toppingCount >= minToppings &&
                    toppingCount <= maxToppings)
                {
                    this.toppings = value;
                }
                else
                {
                    throw new ArgumentException($"Number of toppings should be in range [{minToppings}..{maxToppings}].");
                }
            }

        }
        public double TotalCals
        {
            get => totalCals;
            set => totalCals = value;
        }

        public void AddTopping(Topping topping)
        {
            if (this.toppings.Count < maxToppings)
            {
                this.Toppings.Add(topping);
                this.totalCals += topping.Weight * topping.CalsPerGram;
            }
            else
            {
                throw new ArgumentException($"Number of toppings should be in range [{minToppings}..{maxToppings}].");
            }
        }

        public double GetCalories()
        {
            return TotalCals;
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.totalCals:f2} Calories.";
        }
    }
}
