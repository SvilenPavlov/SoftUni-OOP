using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(" ");
            string pizzaName = input[1];

            List<Topping> toppings = new List<Topping>();
            try
            {

                input = Console.ReadLine().Split(" ");

                string flourType = input[1];
                string bakingTechnique = input[2];
                int weight = int.Parse(input[3]);
                Dough dough = new Dough(flourType, bakingTechnique, weight);

                input = Console.ReadLine().Split(" ");
                while (input[0] != "END")
                {
                    string toppingType = input[1];
                    double toppingWeight = double.Parse(input[2]);


                    Topping topping = new Topping(toppingType, toppingWeight);
                    toppings.Add(topping);
                    input = Console.ReadLine().Split(" ");
                }
                Pizza pizza = new Pizza(pizzaName,dough, toppings);
                Console.WriteLine(pizza);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

