# Recipe Application

This is a command-line application built with C# and Visual Studio that allows users to manage recipe details.

## Functionality

1. **Enter Recipe Details**: 
   - Users can enter the details for a single recipe, including the number of ingredients, each ingredient's name, quantity, unit of measurement, the number of steps, and a description for each step.

2. **Display Recipe**:
   - After entering the recipe details, users can view the full recipe, including ingredients and steps, in a neat format.

3. **Scale Recipe**:
   - Users can request to scale the recipe by a factor of 0.5 (half), 2 (double), or 3 (triple). All ingredient quantities will be adjusted accordingly when displaying the scaled recipe.

4. **Reset Quantities**:
   - Users can reset all ingredient quantities to their original values.

5. **Clear All Data**:
   - Users can clear all entered data to start entering a new recipe.

6. **In-Memory Data Storage**:
   - The application does not persist user data between runs. Data is only stored in memory while the application is running.

## How to Use

1. Clone this repository to your local machine.
2. Open the solution file (`RecipeApp.sln`) in Visual Studio.
3. Build and run the project.
4. Follow the on-screen prompts to interact with the application:
   - Enter recipe details.
   - Display the recipe.
   - Scale the recipe.
   - Reset quantities.
   - Clear all data.
   - Exit the application.

## Dependencies

- This application is built using C# and requires the .NET Framework.

