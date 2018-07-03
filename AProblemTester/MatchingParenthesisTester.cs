using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parenthesis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AProblemTester
{
    [TestClass]
    public class MatchingParenthesisTester
    {
        [TestMethod]
        public void Test()
        {
            var testString = @"Sometimes (when I nest them (my parentheticals) too much (like this (and this))) they get confusing.";
            var p = new MatchingParenthesisProcessor(testString, 10);
            var result = p.FindMatch();
            Assert.IsTrue(result == 79);
        }

        [TestMethod]
        public void Test2()
        {
            var testString = @"Sometimes (when I nest them (my parentheticals) too much (like this (and this))) they get confusing.";
            var p = new MatchingParenthesisProcessor(testString, 28);
            var result = p.FindMatch();
            Assert.IsTrue(result == 46);
        }

        [TestMethod]
        public void Test3()
        {
            var testString = @"Sometimes (when I nest them (my parentheticals) too much (like this (and this))) they get confusing.";
            var p = new MatchingParenthesisProcessor(testString, 57);
            var result = p.FindMatch();
            Assert.IsTrue(result == 78);
        }
    }
}
