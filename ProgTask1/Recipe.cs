using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgTask1
{
    class Ingredient
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }

        public Ingredient(string name, double quantity, string unit)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
        }

        public override string ToString()
        {
            return $"{Quantity} {Unit} of {Name}";
        }
    }

    class Step
    {
        public string Description { get; set; } 

        public Step(string description)
        {
            Description = description;
        }

        public override string ToString()
        {
            return Description;
        }
    }



    class Recipe
    {
        private Ingredient[] ingredients;
        private Step[] steps;

        public Recipe()
        {
            ingredients = new Ingredient[0];
            steps = new Step[0];
        }

        public void AddIngredient(string name, double quantity, string unit)
        {
            Array.Resize(ref ingredients, ingredients.Length + 1);
            ingredients[ingredients.Length - 1] = new Ingredient(name, quantity, unit);
        }

        public void AddStep(string description)
        {
            Array.Resize(ref steps, steps.Length + 1);
            steps[steps.Length - 1] = new Step(description);
        }

        public void DisplayRecipe()
        {
            Console.WriteLine("Recipe:");
            Console.WriteLine("Ingredients:");
            foreach (var ingredient in ingredients)
            {
                Console.WriteLine("- " + ingredient);
            }
            Console.WriteLine("Steps:");
            for (int i = 0; i < steps.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i]}");
            }
        }

        public void ScaleRecipe(double factor)
        {
            foreach (var ingredient in ingredients)
            {
                ingredient.Quantity *= factor;


            }
        }

        public void ResetQuantities()
        {
            // Reset quantities to original values
        }

        public void ClearRecipe()
        {
            ingredients = new Ingredient[0];
            steps = new Step[0];
        }
    }
}