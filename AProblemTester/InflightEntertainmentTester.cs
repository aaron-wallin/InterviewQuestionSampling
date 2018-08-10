using FindTwoIntegersThatDoNotExceedMax;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AProblemTester
{

    [TestClass]
    public class InflightEntertainmentTester
    {
        [TestMethod]
        public void TestA()
        {
            var movieLengths = new int[] { 20, 10, 60, 11, 88, 52 };
            var flightLength = 80;

            var testObj = new TwoMaxCombined(flightLength, movieLengths);
            var result = testObj.DetermineMatch();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestB()
        {
            var movieLengths = new int[] { 20, 10, 60, 11, 88, 52 };
            var flightLength = 99;

            var testObj = new TwoMaxCombined(flightLength, movieLengths);
            var result = testObj.DetermineMatch();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestC()
        {
            var movieLengths = new int[] { 20, 10, 60, 11, 88, 52 };
            var flightLength = 500;

            var testObj = new TwoMaxCombined(flightLength, movieLengths);
            var result = testObj.DetermineMatch();

            Assert.IsFalse(result);
        }
    }
}
