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
    public class BilTests
    {
        [TestMethod()]
        public void PrisTest()
        {
            //Arrange

            var PrisPåBil = new Bil();

            //Act

            int pris = PrisPåBil.Pris();


            Assert.AreEqual(240, pris);
        }

        [TestMethod()]
        public void køretøjTest()
        {
            var køretøjsType = new Bil();

            var type = køretøjsType.køretøj();


            Assert.AreEqual("Bil", type);
        }
    }
}