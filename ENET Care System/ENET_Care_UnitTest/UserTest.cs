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
        public void Login_AdminPassword_True()
        {
            var dummyUser = new Moq.Mock<User>();
            dummyUser.SetupProperty(user => user.Email, "Admin@enetcare.com")
                        .SetupProperty(user => user.Password, "password");
            User userObject = dummyUser.Object;
            Assert.AreNotEqual(null, userObject.login("Admin@enetcare.com", "password"));
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
