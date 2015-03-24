using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ENET_Care.Data;

namespace ENET_Care_UnitTest
{
    [TestClass]
    public class UserTest
    {
        User _user;

        [TestInitialize]
        public void Setup()
        {
            _user = new User();
        }

        [TestMethod]
        public void Login_AgentPassword_True()
        {
            Assert.AreNotEqual(null, _user.login("Agent", "Password"));
        }

        [TestMethod]
        public void UpdateDetails_UpdateEmailAddress_TakingEffect()
        {
            string newEmail = "123@mail.com";
            _user.Email = newEmail;
            _user.CommitToDatabase();
            _user.RetrieveFromDatabase();
            Assert.IsTrue(_user.Email == newEmail);
        }
        [TestMethod]
        public void UpdateDetails_UpdatePassword_TakingEffect()
        {
            string newPassword = "hunter2";
            _user.Password = newPassword;
            _user.CommitToDatabase();
            _user.RetrieveFromDatabase();
            Assert.IsTrue(_user.Password == newPassword);
        }
    }
}
