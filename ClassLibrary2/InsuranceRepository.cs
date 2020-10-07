using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceLibrary
{
    public class InsuranceRepository
    {
        private readonly Dictionary<int, List<string>> _employeeDirectory = new Dictionary<int, List<string>>();
        //Create original

        public bool AddContentToDirectory(int empNum, List<string> DoorNames)
        {
            int startingCount = _employeeDirectory.Count;
            _employeeDirectory.Add(empNum, DoorNames);
            bool wasAdded = (_employeeDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }
        //Read All original

    public Dictionary<int, List<string>> GetContents()
        {
            return _employeeDirectory;
        }
        //Read ONE
        public  InsuranceItems GetContentByTitle(int empNum, List<string> doorNames)
        {
            Dictionary<, List<string>> contents = new Dictionary<int, List<string>>();
            foreach (InsuranceItems singleContent in _employeeDirectory)
            {
                if (singleContent.EmpNum == empNum )
                {
                    return singleContent;
                }

            }
            return null;
        }
        //Update 
        public bool UpdateExistingContent(string originalID, StreamingContent newContent)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle);

            if (oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.StarRating = newContent.StarRating;
                oldContent.MaturityRatin = newContent.MaturityRatin;
                oldContent.TypeOfGenre = newContent.TypeOfGenre;

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
