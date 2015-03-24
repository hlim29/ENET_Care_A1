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
        [TestMethod]
        public void RegisterPackage_InsertDataBase_PackageAdded()
        {
            try
            {
                _agent.RegisterPackage();
            }
            catch
            {
                Assert.Fail();
            }

        }
    }
}
