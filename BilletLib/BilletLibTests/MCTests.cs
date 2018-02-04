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
        public void PrisMCTest()
        {

            //Arrange

            var PrisPåMC = new MC("1234567", DateTime.Today);

            //Act

            int pris = PrisPåMC.Pris();


            Assert.AreEqual(125, pris);
        }

        [TestMethod()]
        public void KøretøjMcTest()
        {
            var køretøjsType = new MC("1234567", DateTime.Today);

            var type = køretøjsType.køretøj();


            Assert.AreEqual("MC", type);
        }
    }
}