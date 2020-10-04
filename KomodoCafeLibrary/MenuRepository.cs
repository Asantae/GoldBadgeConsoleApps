using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafeLibrary
{
    public class MenuRepository
    {
        protected readonly List<MenuItem> _contentDirectory = new List<MenuItem>();
        //Create
        public bool AddContentToDirectory(MenuItem content)
        {
            int startingCount = _contentDirectory.Count;
            _contentDirectory.Add(content);
            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        //Read ALL
        public List<MenuItem> GetContents()
        {
            return _contentDirectory;
        }

        //Read One
        public MenuItem GetContentByName(string mealName)
        {
            foreach(MenuItem singleContent in _contentDirectory)
            {
                if(singleContent.MealName.ToLower() == mealName.ToLower())
                {
                    return singleContent;
                }
            }
            return null;
        }

        //Update
        public bool UpdateExistingContent(string originalName, MenuItem newContent)
        {
            MenuItem oldContent = GetContentByName(originalName);

            if(oldContent != null)
            {
                
                oldContent.MealNum = newContent.MealNum;
                oldContent.MealName = newContent.MealName;
                oldContent.MealDescription = newContent.MealDescription;
                oldContent.Ingredients = newContent.Ingredients;
                oldContent.MealPrice = newContent.MealPrice;

                return true;

            }
            else
            {
                return false;
            }
        }

        //Delete
        public bool DeleteExistingContent(MenuItem existingContent)
        {
            bool deleteResult = _contentDirectory.Remove(existingContent);
            return deleteResult;
        }
    }
}
