using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ENET_Care_Console;

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
            Assert.AreEqual(true, _staff.login("Agent", "Password"));
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
