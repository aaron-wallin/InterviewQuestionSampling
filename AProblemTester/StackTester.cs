using CreateAStack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AProblemTester
{
    [TestClass]
    public class StackTester
    {
        [TestMethod]
        public void Test1()
        {
            var s = new MyStack<int>();
            s.Push(5);
            s.Push(4);
            s.Push(3);
            s.Push(2);
            s.Push(1);

            Assert.IsTrue(s.Pop() == 1);
            Assert.IsTrue(s.Pop() == 2);
            Assert.IsTrue(s.Pop() == 3);
            Assert.IsTrue(s.Pop() == 4);
            Assert.IsTrue(s.Pop() == 5);
        }
    }
}
