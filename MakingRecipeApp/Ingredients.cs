using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingRecipeApp
{
    public class Ingredients
    {
        private string ingredientName, descriptionOfSteps, unitOfMeasurement;
        int numberOfIngredients, numberOfSteps;
        double quantity, originalQuantity;

        public Ingredients()
        {
            this.IngredientName = ingredientName;
            this.DescriptionOfSteps = descriptionOfSteps;
            this.UnitOfMeasurement = unitOfMeasurement;
            this.NumberOfIngredients = numberOfIngredients;
            this.Quantity = quantity;
            this.OriginalQuantity = quantity;
            this.NumberOfSteps = numberOfSteps;
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
                ingredientName = value;
            }
        }
        public string DescriptionOfSteps
        {
            get
            {
                return descriptionOfSteps;
            }
            set
            {
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
                unitOfMeasurement = value;
            }
        }
    }
}
