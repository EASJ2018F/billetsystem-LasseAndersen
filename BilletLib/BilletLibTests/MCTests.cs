using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib.Tests
{
    [TestClass()]
    public class MCTests
    {
        [TestMethod()]
        public void PrisTest()
        {

            //Arrange

            var PrisPåMC = new MC();

            //Act

            int pris = PrisPåMC.Pris();


            Assert.AreEqual(125, pris);
        }

        [TestMethod()]
        public void KøretøjTest()
        {
            var køretøjsType = new MC();

            var type = køretøjsType.Køretøj();


            Assert.AreEqual("MC", type);
        }
    }
}