using System;
using KomodoInsuranceLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InsuranceRepositoryTests
{
    [TestClass]
    public class InuranceTests
    {
        [TestMethod]
        public void SetProperty_ShouldSet()
        {
            InsuranceItems test = new InsuranceItems();
            test.SetDoorNames("D4", "D5");
            test.SetEmployeeNumber(123456);

        }
    }
}
