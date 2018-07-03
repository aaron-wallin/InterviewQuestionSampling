using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RainWater;

namespace AProblemTester
{
    [TestClass]
    public class RainWaterTester
    {
        [TestMethod]
        public void TestMethod9()
        {
            int[] elevations = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            int expected = 6;
            var c = new RainWaterProcessor(elevations);
            var result = c.Process();
            Assert.IsTrue(result == expected, "result is " + result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            int[] elevations = { 9, 8, 8, 8, 8, 8, 8, 8, 9 };
            int expected = 7;
            var c = new RainWaterProcessor(elevations);
            var result = c.Process();
            Assert.IsTrue(result == expected, "result is " + result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] elevations = { 9, 8, 8, 8, 8, 8, 8, 8, 8 };
            int expected = 0;
            var c = new RainWaterProcessor(elevations);
            var result = c.Process();
            Assert.IsTrue(result == expected, "result is " + result);
        }

        [TestMethod]
        public void TestMethod1()
        {
            int[] elevations = { 5, 8, 4, 3, 2, 6, 4, 2, 5 };
            int expected = 13;
            var c = new RainWaterProcessor(elevations);
            var result = c.Process();
            Assert.IsTrue(result == expected, "result is " + result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] elevations = { 3, 4, 6, 3, 5, 7, 4, 2, 5 };
            int expected = 8;
            var c = new RainWaterProcessor(elevations);
            var result = c.Process();
            Assert.IsTrue(result == expected, "result is " + result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] elevations = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int expected = 0;
            var c = new RainWaterProcessor(elevations);
            var result = c.Process();
            Assert.IsTrue(result == expected, "result is " + result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            int[] elevations = { 9, 8, 7, 6, 5, 4, 3, 2, 3 };
            int expected = 1;
            var c = new RainWaterProcessor(elevations);
            var result = c.Process();
            Assert.IsTrue(result == expected, "result is " + result);
        }

        [TestMethod]
        public void TestMethod7()
        {
            int[] elevations = { 9, 8, 9, 8, 9, 8, 9, 8, 9 };
            int expected = 4;
            var c = new RainWaterProcessor(elevations);
            var result = c.Process();
            Assert.IsTrue(result == expected, "result is " + result);
        }

        [TestMethod]
        public void TestMethod8()
        {
            int[] elevations = { 3, 6, 4, 4, 7, 2, 8, 2, 4 };
            int expected = 11;
            var c = new RainWaterProcessor(elevations);
            var result = c.Process();
            Assert.IsTrue(result == expected, "result is " + result);
        }
    }
}
