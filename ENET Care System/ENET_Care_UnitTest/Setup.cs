using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;



using System.IO;namespace ENET_Care_UnitTest
{
    [TestClass]
    public class Setup
    {
        [AssemblyInitialize]
        public static void SetupConnectionPath(TestContext context)
        {

            AppDomain.CurrentDomain.SetData("DataDirectory", Path.GetFullPath(@"..\..\..\ENET_Care_Console\App_Data"));
        }
    }
}
