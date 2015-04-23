using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ENET_Care.Business;
using ENET_Care.Data;

namespace ENET_Care.Tests
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void UserTest_EditName_NameEditted()
        {
            //editting to a new name
            String id = "1";
            String newName = "Id1NewName";
            UserLogic.EditName(id, newName);

            //checking edit
            Assert.AreEqual(newName, UserLogic.GetName());
        }
        [TestMethod]
        public void UserTest_EditPassword_PasswordEditted()
        {
            //editting to a new password
            String id = "1";
            String newPassword = "Id1NewPassword";
            UserLogic.EditName(id, newPassword);

            //checking edit
            Assert.AreEqual(newPassword, UserLogic.GetPassword());
        }
        [TestMethod]
        public void UserTest_EditEmailAddress_EmailAddressEditted()
        {
            //editting to a new email address
            String id = "1";
            String newEmailAddress = "Id1EmailAddress@enetcare.org";
            UserLogic.EditName(id, newEmailAddress);

            //checking edit
            Assert.AreEqual(newEmailAddress, UserLogic.GetEmailAddress());
        }
        [TestMethod]
        public void UserTest_EditDistributionCentre_DistributionCentreEditted()
        {
            //editting to a new email address
            String id = "1";
            String newDistributionCentre = "Id1DistributionCentre";
            UserLogic.EditName(id, newDistributionCentre);

            //checking edit
            Assert.AreEqual(newDistributionCentre, UserLogic.GetDistributionCentre(id));
        }
    }
}
