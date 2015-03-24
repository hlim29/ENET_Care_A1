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
        public void Login_AgentPassword_True()
        {
            Assert.AreNotEqual(null, _staff.login("Agent", "Password"));
        }

        [TestMethod]
        public void DatabaseConnect_CommitToDatabase_RetrieveFromDatabase()
        {
            var dummyStaff = new Moq.Mock<Staff>();
            dummyStaff.SetupProperty(staff => staff.firstName, "First")
                        .SetupProperty(staff => staff.lastName, "Last")
                        .SetupProperty(staff => staff.type, "Agent")
                        .SetupProperty(staff => staff.email, "Email@email.com")
                        .SetupProperty(staff => staff.password, "p455w0rd");
            Staff staffObject = dummyStaff.Object;
            staffObject.CommitToDatabase();
            _staff.RetrieveFromDatabase();
            Assert.AreEqual(_staff, staffObject);
        }
        [TestMethod]
        public void UpdateDetails_UpdateEmailAddress_TakingEffect()
        {
            string newEmail = "123@mail.com";
            _staff.email = newEmail;
            _staff.CommitToDatabase();
            _staff.RetrieveFromDatabase();
            Assert.IsTrue(_staff.email == newEmail);
        }
        [TestMethod]
        public void UpdateDetails_UpdatePassword_TakingEffect()
        {
            string newPassword = "hunter2";
            _staff.password = newPassword;
            _staff.CommitToDatabase();
            _staff.RetrieveFromDatabase();
            Assert.IsTrue(_staff.password == newPassword);
        }

    }
}
