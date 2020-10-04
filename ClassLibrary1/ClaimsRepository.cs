using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace KomodoClaimsLibrary
{
    public class ClaimsRepository
    {
        protected readonly List<ClaimItems> _contentDirectory = new List<ClaimItems>();
        //Create
        public bool AddContentToDirectory(ClaimItems content)
        {
            int startingCount = _contentDirectory.Count;
            _contentDirectory.Add(content);
            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }
        //Read All
        public List<ClaimItems> GetContents()
        {
            return _contentDirectory;
        }

        //Read One
        public ClaimItems GetContentByID(int claimID)
        {
            foreach(ClaimItems singleContent in _contentDirectory)
            {
                if(singleContent.ClaimID == claimID)
                {
                    return singleContent;
                }
            }
            return null;
        }

        //Update
        public bool UpdateExistingContent(int originalID, ClaimItems newContent)
        {
            ClaimItems oldContent = GetContentByID(originalID);

            if (oldContent != null)
            {
                oldContent.ClaimID = newContent.ClaimID;
                oldContent.TypeOfClaim = newContent.TypeOfClaim;
                oldContent.Description = newContent.Description;
                oldContent.ClaimAmount = newContent.ClaimAmount;
                oldContent.DateOfIncident = newContent.DateOfIncident;
                oldContent.DateOfClaim = newContent.DateOfClaim;
                oldContent.IsValid = newContent.IsValid;

                return true;
            }
            else
            {
                return false;
            }
        }

        //Delete
        public bool DeleteExistingContent(ClaimItems existingContent)
        {
            bool deleteResult = _contentDirectory.Remove(existingContent);
            return deleteResult;
        }
    }
}
