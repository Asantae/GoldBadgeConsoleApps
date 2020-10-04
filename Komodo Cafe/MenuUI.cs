using KomodoCafeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Cafe
{
    public class MenuUI
    {
        private readonly MenuRepository _menuRepo = new MenuRepository();
        //Call the MenuUI to console
        public void Run()
        {
            SeedContent();
            menuUI();
        }

        public void menuUI()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do? \n \n " +
                    "1) Add Item \n \n " +
                    "2) See All Menu Items \n \n " +
                    "3) Delete Item \n \n " +
                    "4) Exit Program ");
                int userResponseMenu = Convert.ToInt32(Console.ReadLine());
                //userInteraction();
                switch (userResponseMenu)
                {
                    case 1:
                        AddItem();
                        break;
                    case 2:
                        ShowAllContent();
                        break;
                    case 3:
                        DeleteItem();
                        break;
                    case 4:
                        continueToRun = false;
                        break;
                }
            }
        }

        private void AddItem()
        {
            MenuItem content = new MenuItem();
            Console.Clear();
            Console.WriteLine("What is the meal name?");
            string userAddedMealName = Console.ReadLine();
            content.MealName = userAddedMealName;
            Console.WriteLine("What is the meal number?");
            int userAddedMealNum = Convert.ToInt32(Console.ReadLine());
            content.MealNum = userAddedMealNum;
            Console.WriteLine("What is the meal price?");
            double userAddedPrice = Convert.ToDouble(Console.ReadLine());
            content.MealPrice = userAddedPrice;
            Console.WriteLine("Briefly describe he meal.");
            string userAddedDescription = Console.ReadLine();
            content.MealDescription = userAddedDescription;
            Console.WriteLine("What are the ingredients?");
            string userAddedIngredients = Console.ReadLine();
            content.Ingredients = userAddedIngredients;
            _menuRepo.AddContentToDirectory(content);
            Console.WriteLine("Item successfully added!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private void ShowAllContent()
        {
            Console.Clear();
            List<MenuItem> listOfContents = _menuRepo.GetContents();
            foreach (MenuItem content in listOfContents)
            {
                DisplaySimple(content);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private void DeleteItem()
        {
            Console.Clear();
            Console.WriteLine("Which item would you like to delete?");
            List<MenuItem> contentList = _menuRepo.GetContents();
            int count = 0;
            foreach (var content in contentList)
            {
                count++;
                Console.WriteLine($"{count}) {content.MealName}");
            }
            int TargetContentID = Convert.ToInt32(Console.ReadLine());
            int correctIndex = TargetContentID - 1;
            if (correctIndex >= 0 && correctIndex < contentList.Count)
            {
                MenuItem desiredContent = contentList[correctIndex];
                if (_menuRepo.DeleteExistingContent(desiredContent))
                {
                    Console.WriteLine($"{desiredContent} was successfully deleted!");
                }
                else
                {
                    Console.WriteLine("I'm sorry, I'm afraid I can't do that.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("INVALID OPTION");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        private void DisplaySimple(MenuItem content)
        {
            Console.WriteLine($"{content.MealName} \n" +
                "----------------------------");
        }

        private void SeedContent()
        {
            var firstItem = new MenuItem("Toast", 1, "Heated Bread", "Bread, Butter, Heat", 1.00);
            _menuRepo.AddContentToDirectory(firstItem);
        }
    }
}
