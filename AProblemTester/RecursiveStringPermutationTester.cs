using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecursiveStringPermutations;
using StockPrices;

namespace AProblemTester
{
    [TestClass]
    public class RecursiveStringPermutationTester
    {
        [TestMethod]
        public void Test1()
        {
            var sp = new RecursivePermutationProcessor("abcd");
            var myList = sp.Process();
            Assert.IsTrue(myList.Count == 24);
        }
    }
}
