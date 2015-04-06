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
        /**
         * Update distribution centre allocation in Staff Object.
         */
        [TestMethod]
        public void UpdateDetails_UpdateDistributionCentre_TakingEffect()
        {
            DistributionCentre newDC = new DistributionCentre();
            Staff staffObject = createStaffMock();
            //staffObject.UpdateDistributionCentre(newDC); //need to be uncomment after the method built
            Assert.AreEqual(staffObject.DistributionCentre, newDC);
        }
        /**
         * Commit to database, and retrieve it to check the database connection
         *  PS: Still changing the actual database, need updated for better approach
         */

        [TestMethod]
        public void DatabaseConnect_CommitToDatabase_RetrieveFromDatabase()
        {
            Staff staffObject = createStaffMock();
            staffObject.CommitToDatabase(); //Change the actual database, updated later for better approach
            _staff.RetrieveFromDatabase();
            Assert.AreEqual(_staff, staffObject);
        }
        /**
         * Create Mock Staff Object for test purposes
         */
        private Staff createStaffMock()
        {
            var dummyStaff = new Moq.Mock<Staff>();
            dummyStaff.SetupProperty(staff => staff.FirstName, "First")
                        .SetupProperty(staff => staff.LastName, "Last")
                        .SetupProperty(staff => staff.Role, "Agent")
                        .SetupProperty(staff => staff.DistributionCentre, new DistributionCentre());
            return dummyStaff.Object;
        }
    }
}
