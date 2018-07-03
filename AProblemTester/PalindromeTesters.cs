using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicPalindrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockPrices;

namespace AProblemTester
{
    [TestClass]
    public class PalindromeTester
    {
        [TestMethod]
        public void Test1()
        {
            var sp = new BasicPalindromeProcessor("dog");
            var result = sp.Process();
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test2()
        {
            var sp = new BasicPalindromeProcessor("civic");
            var result = sp.Process();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test3()
        {
            var sp = new BasicPalindromeProcessor("a santa at nasa");
            var result = sp.Process();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test4()
        {
            var sp = new BasicPalindromeProcessor("a rsanta at nasa");
            var result = sp.Process();
            Assert.IsFalse(result);
        }
    }
}
