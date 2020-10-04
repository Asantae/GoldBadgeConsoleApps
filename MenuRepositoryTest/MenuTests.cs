using System;
using KomodoCafeLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MenuRepositoryTest
{
    [TestClass]
    public class MenuTests
    {
        [TestMethod]
        public void SetMenuProperty_ShouldSetCorrectly()
        {
            MenuItem popcorn = new MenuItem("", 90, "Heated corn kernals", "Corn kernals",1.23 );
            popcorn.SetMealName("Popcorn");
            popcorn.SetMealNum(1);
            Console.WriteLine(popcorn.MealName + " is Meal Number:" + popcorn.MealNum);
        }
        [TestMethod]
        public void MenuTest_Toast()
        {
            MenuItem toast = new MenuItem();
            toast.SetMealNum(2);
            toast.SetMealName("Toast");
            toast.SetMealDescription("Cooked Bread");
            toast.SetIngredients("Bread, Butter, Heat");
            toast.SetMealPrice(1.00);
            Console.WriteLine(toast.MealNum + " " + toast.MealName + " " + toast.MealDescription + ". " + toast.Ingredients + " $" + toast.MealPrice );
        }
    }
}
