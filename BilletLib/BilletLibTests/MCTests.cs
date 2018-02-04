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

            var PrisPåMC = new MC();

            //Act

            int pris = PrisPåMC.Pris();


            Assert.AreEqual(125, pris);
        }

        [TestMethod()]
        public void KøretøjMcTest()
        {
            var køretøjsType = new MC();

            var type = køretøjsType.køretøj();


            Assert.AreEqual("MC", type);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Nummerplade var for lang")]
        public void NummerpladeForLangMC()
        {
            //Arrange

            MC mc9 = new MC();

            //Act

            mc9.Nummerplade = "12345678";

            //Assert

            Assert.AreEqual(8, mc9.NummerpladeCheck());


        }
    }
}