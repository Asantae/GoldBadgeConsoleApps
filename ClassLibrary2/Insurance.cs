using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceLibrary
{
    public class InsuranceItems
    {
        public int EmpNum { get; set; }
        public List<string> DoorNames { get; set; }
        public InsuranceItems() { }
        public InsuranceItems(List<string> doorNames)
        {
            DoorNames = doorNames;
        }
        public InsuranceItems(int empNum)
        {
            EmpNum = empNum;
        }
        public InsuranceItems(int empNum, List<string> doorNames)
        {
            EmpNum = empNum;
            DoorNames = doorNames;
        }
        public void SetEmployeeNumber(int empNum)
        {
            EmpNum = empNum;
        }
        public void SetDoorNames(List<string> doorNames)
        {
            DoorNames = doorNames;
        }

    }
}
