using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoClaimsLibrary
{
    public enum ClaimType
    {
        Car = 1,
        Home,
        Theft
    }
    public class ClaimItems
    {
        public int ClaimID { get; set; }
        public ClaimType TypeOfClaim { get; set; }
        public string Description { get; set; }
        public double ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid { get; set; }

        public ClaimItems() { }
        public ClaimItems(int claimID, ClaimType tOC, string description, double claimAmount, DateTime dOI, DateTime dOC, bool isValid)
        {
            ClaimID = claimID;
            TypeOfClaim = tOC;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dOI;
            DateOfClaim = dOC;
            IsValid = isValid;
        }
        public void SetClaimID(int claimID)
        {
            ClaimID = claimID;
        }
        public void SetTypeOfClaim(ClaimType tOC)
        {
            TypeOfClaim = tOC;
        }
        public void SetDescription(string description)
        {
            Description = description;
        }
        public void SetClaimAmount(double claimAmount)
        {
            ClaimAmount = claimAmount;
        }
        public void SetDateOfIncident(DateTime dOI)
        {
            DateOfIncident = dOI;
        }
        public void SetDateOfClaim(DateTime dOC)
        {
            DateOfClaim = dOC;
        }
        public void SetIsValid(bool isValid)
        {
            IsValid = isValid;
        }
    }
}
