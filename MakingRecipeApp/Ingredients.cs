using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingRecipeApp
{
    public class Ingredients
    {
        private string ingredientName, unitOfMeasurement;
        private string[] descriptionOfSteps;
        private int numberOfIngredients, numberOfSteps;
        private double quantity, originalQuantity;
        private string recipeName;


        public Ingredients(string recipeName,string ingredientName, string[] descriptionOfSteps, string unitOfMeasurement, int numberOfIngredients, int numberOfSteps, double quantity, double originalQuantity)
        {
            this.ingredientName = ingredientName;
            this.descriptionOfSteps = descriptionOfSteps;
            this.unitOfMeasurement = unitOfMeasurement;
            this.numberOfIngredients = numberOfIngredients;
            this.numberOfSteps = numberOfSteps;
            this.quantity = quantity;
            this.originalQuantity = originalQuantity;
            this.recipeName = recipeName;
        }

        public int NumberOfIngredients
        {
            get
            {
                return numberOfIngredients;
            }
            set
            {
                numberOfIngredients = value;
            }
        }
        public double Quantity
        {
            get
            {
                return quantity;

            }
            set
            {
                if (quantity < 0) {
                    Console.WriteLine("The quantity can not be less than 0");
                }
                quantity = value;
            }
        }

        public double OriginalQuantity
        {
            get
            {
                return originalQuantity;
            }
            set
            {
                originalQuantity = value;
            }
        }

        public int NumberOfSteps
        {
            get
            {
                return numberOfSteps;
            }
            set
            {
                numberOfSteps = value;
            }
        }
        public string IngredientName
        {
            get
            {
                return ingredientName;
            }
            set
            {
                if(ingredientName == null )
                {
                    Console.WriteLine("Please enter the ingredient name");
                }
                ingredientName = value;
            }
        }
        public string[] DescriptionOfSteps
        {
            get
            {
                return descriptionOfSteps;
            }
            set
            {
                if (descriptionOfSteps == null)
                {
                    Console.WriteLine($"Please enter appropriate values for the description");
                }
                descriptionOfSteps = value;
            }
        }
        public string UnitOfMeasurement
        {
            get
            {
                return unitOfMeasurement;
            }
            set
            {
                if (unitOfMeasurement == null)
                {
                    Console.WriteLine($"Please enter appropriate values for the measuring units");
                }
                unitOfMeasurement = value;
            }
        }

        public string RecipeName {

            get
            {
                return recipeName;
            }
            set
            {
                if (recipeName == null)
                {
                    Console.WriteLine($"Please enter appropriate values for the measuring units");
                }
                recipeName = value;
            }
        }
    }
}
