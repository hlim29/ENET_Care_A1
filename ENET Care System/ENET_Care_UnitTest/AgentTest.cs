using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ENET_Care_Console;

namespace ENET_Care_UnitTest
{
    [TestClass]
    public class AgentTest
    {
        Agent _agent;

        [TestInitialize]
        public void Setup()
        {
            _agent = new Agent();
        }
        //[TestMethod]
        //public void Login_AgentPassword_True()
        //{
        //    Assert.AreEqual(true, Agent.Login("Agent", "Password"));
        //}
        //[TestMethod]
        //public void Register_GenerateBarcode_Numbers()
        //{
        //    Assert.AreEqual(12344223773, Agent.GetBarcode());
        //}
        //[TestMethod]
        //public void Register_InsertPolioVacination_PolioVacination()
        //{
        //    Agent.SelectType("Polio Vaccination");
        //    Assert.AreEqual("Polio Vacination", Agent.Type);
        //}
        //[TestMethod]
        //public void Register_InsertExpiryDate_ExpiryDate()
        //{
        //    Agent.InsertExpiryDate("11/11/17");
        //    Assert.AreEqual("11/11/17", Agent.ExpiryDate);
        //}

        ///////////

        [TestMethod]
        public void UpdateDetails_UpdateEmailAddress_TakingEffect()
        {
            string newEmail = "123@mail.com";
            _agent.Email = newEmail;
            _agent.CommitToDatabase();
            _agent.RetrieveFromDatabase();
            Assert.IsTrue(_agent.Email == newEmail);
        }

        [TestMethod]
        public void UpdateDetails_UpdatePassword_TakingEffect()
        {
            string newPassword = "hunter2";
            _agent.Password = newPassword;
            _agent.CommitToDatabase();
            _agent.RetrieveFromDatabase();
            Assert.IsTrue(_agent.Password == newPassword);
        }

    }
}
