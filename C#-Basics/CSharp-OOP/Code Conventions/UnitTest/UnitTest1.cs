using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_PrintCount()
        {
            Male.PrintMaleCount();
        }

        [TestMethod]
        public void Test_MaleInitilizedProperly()
        {
            Male newMale =  new Male("John", 20, 175);
			Assert.AreEqual(newMale.Gender, "male");
			Assert.AreEqual(newMale.Name, "John");
			Assert.AreEqual(newMale.Age, 20);
			Assert.AreEqual(newMale.Height, 175);
        }

        [TestMethod]
        public void Test_FemaleInitilizedProperly()
        {
            Female newFemale =  new Female("Emilly", 19, 170);
			Assert.AreEqual(newMale.Gender, "feale");
			Assert.AreEqual(newMale.Name, "Emilly");
			Assert.AreEqual(newMale.Age, 19);
			Assert.AreEqual(newMale.Height, 170);
        }
    }

   
}
