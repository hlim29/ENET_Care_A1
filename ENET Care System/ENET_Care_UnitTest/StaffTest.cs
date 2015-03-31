using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ENET_Care.Data;

namespace ENET_Care_UnitTest
{
    [TestClass]
    public class StaffTest
    {
        Staff _staff;

        [TestInitialize]
        public void Setup()
        {
            _staff = new Staff();
        }

        [TestMethod]
        public void DatabaseConnect_CommitToDatabase_RetrieveFromDatabase()
        {
            var dummyStaff = new Moq.Mock<Staff>();
            dummyStaff.SetupProperty(staff => staff.FirstName, "First")
                        .SetupProperty(staff => staff.LastName, "Last")
                        .SetupProperty(staff => staff.Role, "Agent");
            Staff staffObject = dummyStaff.Object;
            staffObject.CommitToDatabase();
            _staff.RetrieveFromDatabase();
            Assert.AreEqual(_staff, staffObject);
        }


    }
}
