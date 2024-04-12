using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Recipe recipe = new Recipe();

            // User-friendly terminal interface for adding recipe specifics

            Console.WriteLine("Enter recipe details:");

            // Add ingredients
            Console.Write("Enter the number of ingredients: ");
            int ingredientCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < ingredientCount; i++)
            {
                Console.Write($"Ingredient {i + 1} name: ");
                string name = Console.ReadLine();
                Console.Write($"Quantity of {name}: ");
                double quantity = double.Parse(Console.ReadLine());
                Console.Write($"Unit of measurement: ");
                string unit = Console.ReadLine();
                recipe.AddIngredient(name, quantity, unit);
            }

            // Add steps
            Console.Write("Enter the number of steps: ");
            int stepCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < stepCount; i++)
            {
                Console.Write($"Step {i + 1}: ");
                string description = Console.ReadLine();
                recipe.AddStep(description);
            }

            // Display recipe
            recipe.DisplayRecipe();

            // Scaling the recipe
            Console.WriteLine("Do you want to scale the recipe? (y/n)");
            if (Console.ReadLine().ToLower() == "y")
            {
                Console.Write("Enter scale factor (0.5, 2, or 3): ");
                double factor = double.Parse(Console.ReadLine());
                recipe.ScaleRecipe(factor);
                recipe.DisplayRecipe();
            }
        }
    }
}

       
