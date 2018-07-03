using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockPrices;

namespace AProblemTester
{
    [TestClass]
    public class StockPriceTester
    {
        [TestMethod]
        public void Test1()
        {
            var sp = new StockPriceProcessor(new int[] { 10, 7, 5, 500, 8, 11, 20000, 9 });
            var max = sp.Process();
            Assert.IsTrue(max == 19995);
        }
    }
}
