using MakingRecipeApp;

internal class Program
{
    public static void Main(string[] args)
    {
        //Variable Declarations
        int numberOfIngredients;
        int numberOfSteps = 0;
        int choice;
        recipeChoices();
        Console.Write("Please select your option: ");
        choice = Convert.ToInt32(Console.ReadLine());
        Ingredients ingredients = new Ingredients();
        Console.Write($"How many ingredients does your recipe have: ");
        numberOfIngredients = Convert.ToInt32(Console.ReadLine());

        Ingredients[] myIngredients = new Ingredients[numberOfIngredients];
        while (choice != 6 || (choice > 6) && (choice <= 0))
        {
            if (choice == 1)
            {
                myIngredients = new Ingredients[numberOfIngredients];
                for (int i = 0; i < myIngredients.Length; i++)
                {
                    myIngredients[i] = new Ingredients();
                    Console.Write("Enter the name of the ingredient: ");
                    myIngredients[i].IngredientName = Console.ReadLine();

                    Console.Write($"How much of {myIngredients[i].IngredientName} do you need: ");
                    myIngredients[i].Quantity = Convert.ToInt64(Console.ReadLine());
                    myIngredients[i].OriginalQuantity = myIngredients[i].Quantity;
                    Console.Write($"Which quantity unit will be used to measure the ingredient: ");
                    myIngredients[i].UnitOfMeasurement = Console.ReadLine();
                }

                Console.Write("How many steps are there to make this recipe: ");
                numberOfSteps = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the steps to create the recipe:\n");
                for (int x = 0; x < myIngredients.Length; x++)
                {
                    myIngredients[x].DescriptionOfSteps = $"{x + 1}. {Console.ReadLine()}\n";
                }
                Console.WriteLine("\n");
                recipeChoices();
                choice = Convert.ToInt32(Console.ReadLine());
            }
            else if (choice == 2)
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
                        Console.WriteLine($"Quantity: {myIngredients[i].Quantity}");
                        Console.WriteLine($"Unit of measurement: {myIngredients[i].UnitOfMeasurement}");
                        Console.WriteLine($"Steps:\n{myIngredients[i].DescriptionOfSteps}");
                    }
                }
                recipeChoices();
                choice = Convert.ToInt32(Console.ReadLine());

            }
            else if (choice == 3)
            {
                Console.WriteLine($"1. Scale by 0.5");
                Console.WriteLine($"2. Scale by 2");
                Console.WriteLine($"3. Scale by 3");
                Console.WriteLine($"4. Exit the scalor");
                int userChoice = Convert.ToInt32(Console.ReadLine());

                while (userChoice != 4)
                {
                    if (userChoice == 1)
                    {
                        for (int ingredientLoop = 0; ingredientLoop < myIngredients.Length; ingredientLoop++)
                        {
                            myIngredients[ingredientLoop].Quantity *= 0.5;
                            Console.WriteLine($"1. Scale by 0.5");
                            Console.WriteLine($"2. Scale by 2");
                            Console.WriteLine($"3. Scale by 3");
                            Console.WriteLine($"4. Exit the scalor");
                            userChoice = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    else if (userChoice == 2)
                    {
                        for (int ingredientLoop = 0; ingredientLoop < myIngredients.Length; ingredientLoop++)
                        {
                            myIngredients[ingredientLoop].Quantity *= 2;
                            Console.WriteLine($"1. Scale by 0.5");
                            Console.WriteLine($"2. Scale by 2");
                            Console.WriteLine($"3. Scale by 3");
                            Console.WriteLine($"4. Exit the scalor");
                            userChoice = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    else if (userChoice == 3)
                    {
                        for (int ingredientLoop = 0; ingredientLoop < myIngredients.Length; ingredientLoop++)
                        {
                            myIngredients[ingredientLoop].Quantity *= 3;
                            Console.WriteLine($"1. Scale by 0.5");
                            Console.WriteLine($"2. Scale by 2");
                            Console.WriteLine($"3. Scale by 3");
                            Console.WriteLine($"4. Exit the scalor");
                            userChoice = Convert.ToInt32(Console.ReadLine());
                        }

                    }

                    else
                    {
                        Console.WriteLine($"This is an invalid choice");
                        Console.WriteLine($"1. Scale by 0.5");
                        Console.WriteLine($"2. Scale by 2");
                        Console.WriteLine($"3. Scale by 3");
                        Console.WriteLine($"4. Exit the scalor");
                        userChoice = Convert.ToInt32(Console.ReadLine());
                    }
                    recipeChoices();
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                
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
                Array.Clear(myIngredients, 0, myIngredients.Length);
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
}