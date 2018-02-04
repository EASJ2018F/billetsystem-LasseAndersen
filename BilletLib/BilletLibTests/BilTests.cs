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

            var PrisPåBil = new Bil();

            //Act

            int pris = PrisPåBil.Pris();

            //Assert

            Assert.AreEqual(240, pris);
        }

        [TestMethod()]
        public void køretøjBilTest()
        {
            var køretøjsType = new Bil();

            var type = køretøjsType.køretøj();


            Assert.AreEqual("Bil", type);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException),"Nummerplade var for lang")]

        public void NummerPladeForLangBil()
        {
            //Arrange
           
            Bil b9 = new Bil();

            //Act

            b9.Nummerplade = "12345678";

            //Assert

            Assert.AreEqual(8, b9.NummerpladeCheck());


        }
        [TestMethod()]
        public void WeekendRabat()
        {
            //Arrange

            Bil b99 = new Bil();

            //Act
            b99.weekendRabat = true;
            //Assert


        }

        //[TestMethod()]
        //public void StorRabat()
        //{

        //    var tyveprocentrabat = new Bil();

        //    var rabat = tyveprocentrabat.rabat(240);

        //    Assert.AreEqual(48, rabat);

        //}

    }
}