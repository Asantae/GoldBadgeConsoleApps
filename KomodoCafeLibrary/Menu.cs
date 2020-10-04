using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafeLibrary
{
    public class MenuItem
    {
        public int MealNum { get; set; }
        public string MealName { get; set; }
        public string MealDescription { get; set; }
        public string Ingredients { get; set; }
        public double MealPrice { get; set; }

        public MenuItem() { }
        public MenuItem(string mealName, int mealNum, string mealDescription, string ingredients, double mealPrice)
        {
             MealName = mealName;
             MealNum = mealNum;
             MealDescription = mealDescription;
             Ingredients = ingredients;
             MealPrice = mealPrice;
        }
        public void SetMealName(string mealName)
        {
            MealName = mealName;
        }
        public void SetMealNum(int mealNum)
        {
            MealNum = mealNum;
        }
        public void SetMealPrice(double mealPrice)
        {
            MealPrice = mealPrice;
        }
        public void SetMealDescription(string mealDescription)
        {
            MealDescription = mealDescription;
        }
        public void SetIngredients(string ingredients)
        {
            Ingredients = ingredients;
        }
    }
}
        
