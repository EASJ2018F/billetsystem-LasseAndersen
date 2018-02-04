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
        public void PrisBilTest()
        {
            //Arrange

            var PrisPåBil = new Bil("1234567", DateTime.Today);

            //Act

            int pris = PrisPåBil.Pris();


            Assert.AreEqual(240, pris);
        }

        [TestMethod()]
        public void køretøjBilTest()
        {
            var køretøjsType = new Bil("1234567",DateTime.Today);

            var type = køretøjsType.køretøj();


            Assert.AreEqual("Bil", type);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException),"Nummerplade var for lang")]

        public void TjekNummerPladeLængdetest()
        {
            //Arrange
           
            Bil b9 = new Bil("12345678", DateTime.Today);


        }
        
    }
}