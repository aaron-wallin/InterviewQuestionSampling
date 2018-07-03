using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecursiveStringPermutations;
using StockPrices;
using StringPermutationIsPalindrome;

namespace AProblemTester
{
    [TestClass]
    public class PermutationPalindromeTester
    {
        [TestMethod]
        public void Test1()
        {
            var sp = new StringPermutationPalindromeProcessor("iiccv");
            var result = sp.Process();
            Assert.IsTrue(result);
        }
    }
}
