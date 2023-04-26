using MakingRecipeApp;

internal class Program
{
    public static void Main(string[] args)
    {
        //Variable Declarations
        int numberOfIngredients, choice;
        int numberOfSteps = 0;
        string[] descriptionOfSteps;
        string ingredientName, unitOfMeasurement;
        double quantityOfIngredients, originalQuantity;

        Console.WriteLine("Enter recipe name:");
        string recipeName = Console.ReadLine();

        // Prompt user for number of ingredients
        Console.WriteLine("Enter number of ingredients:");
        numberOfIngredients = Convert.ToInt32(Console.ReadLine());
        recipeChoices();
        Console.Write("Please select your option: ");
        choice = Convert.ToInt32(Console.ReadLine());

        Ingredients[] myIngredients = new Ingredients[numberOfIngredients];
        while (choice != 6 || (choice > 6) && (choice <= 0))
        {
            if (choice == 1)
            {
                myIngredients = new Ingredients[numberOfIngredients];
                for (int i = 0; i < myIngredients.Length; i++)
                {
                    Console.Write("Enter the name of the ingredient: ");
                    ingredientName = Console.ReadLine();

                    Console.Write($"How much of {ingredientName} do you need: ");
                    quantityOfIngredients = Convert.ToDouble(Console.ReadLine());
                    originalQuantity = quantityOfIngredients;
                    Console.Write($"Which quantity unit will be used to measure the ingredient: ");
                    unitOfMeasurement = Console.ReadLine();
                    Console.Write("How many steps are there to make this recipe: ");
                    numberOfSteps = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the steps to create the recipe:\n");
                    descriptionOfSteps = new string[numberOfSteps];
                    for (int x = 0; x < numberOfSteps; x++)
                    {
                        descriptionOfSteps[x] = Console.ReadLine();
                    }

                    myIngredients[i] = new Ingredients(recipeName, ingredientName, descriptionOfSteps, unitOfMeasurement, numberOfIngredients, numberOfSteps, quantityOfIngredients, originalQuantity);
                }


                recipeChoices();
                choice = Convert.ToInt32(Console.ReadLine());
            }
            else if (choice == 2)
            {
                DisplayIngredients(myIngredients);
                recipeChoices();
                choice = Convert.ToInt32(Console.ReadLine());

            }
            else if (choice == 3)
            {
                ScaleQuantityOfIngredients(myIngredients);
                recipeChoices();
                choice = Convert.ToInt32(Console.ReadLine());
            }
            else if (choice == 4)
            {
                Console.WriteLine("Are you sure you want to reset the recipe? (y/n)");
                string input = Console.ReadLine();
                for (int loopClearArray = 0; loopClearArray < myIngredients.Length; loopClearArray++)
                {
                    if (input == "y")
                    {
                        myIngredients[loopClearArray].Quantity = myIngredients[loopClearArray].OriginalQuantity;
                        Console.WriteLine("Recipe reset successfully.");
                        recipeChoices();
                        choice = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (input == "n")
                    {
                        recipeChoices();
                        choice = Convert.ToInt32(Console.ReadLine());
                    }
                }

            }
            else if (choice == 5)
            {
                ClearIngredients(myIngredients);
                recipeChoices();
                choice = Convert.ToInt32(Console.ReadLine());
                continue;
            }
            else if (choice == 6)
            {
                Console.WriteLine("Program is exiting...");
                break;
            }
            else
            {
                Console.WriteLine("Option is invalid");
                recipeChoices();
                choice = Convert.ToInt32(Console.ReadLine());
                continue;
            }
        }
    }

    private static void recipeChoices()
    {
        Console.WriteLine($"1. Create Recipe");
        Console.WriteLine($"2. Display Recipe");
        Console.WriteLine($"3. Scale Ingredients");
        Console.WriteLine($"4. Reset Ingredients");
        Console.WriteLine($"5. Clear Recipe");
        Console.WriteLine($"6. Exit Program");
    }
    public static void DisplayIngredients(Ingredients[] myIngredients)
    {
        for (int i = 0; i < myIngredients.Length; i++)
        {
            if (myIngredients[i] == null)
            {
                Console.WriteLine("There is nothing stored here. Please enter your ingredients");
            }
            else
            {
                Console.WriteLine($"Name of Ingredient: {myIngredients[i].IngredientName}");
                Console.WriteLine($"Quantity: {myIngredients[i].Quantity} {myIngredients[i].UnitOfMeasurement}");
                for (int stepsIterations = 0; stepsIterations < myIngredients[i].DescriptionOfSteps.Length; stepsIterations++)
                {
                    Console.WriteLine($"{stepsIterations + 1}. {myIngredients[i].DescriptionOfSteps[stepsIterations]}");
                }
            }
        }
        Console.WriteLine("\n");
    }
    public static void ClearIngredients(Ingredients[] myIngredients)
    {
        Array.Clear(myIngredients, 0, myIngredients.Length);

    }
    public static void ScaleQuantityOfIngredients(Ingredients[] myIngredients)
    {
        Console.WriteLine("Enter scaling factor (e.g. 0.5, 2, 3):");
        double scalingFactor = Convert.ToDouble(Console.ReadLine());

        for (int i = 0; i < myIngredients.Length; i++)
        {
            myIngredients[i].Quantity *= scalingFactor;
        }
    }
}