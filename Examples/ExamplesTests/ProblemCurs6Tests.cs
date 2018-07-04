using Microsoft.VisualStudio.TestTools.UnitTesting;
using Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Tests
{
    [TestClass()]
    public class ProblemCurs6Tests
    {
        [TestMethod()]
        public void nextInSequenceTest()
        {
            var ceva = new ProblemCurs6();
            Assert.AreEqual(40, ceva.nextInSequence(13));
        }
        [TestMethod()]
        public void nextInSequenceTest2()
        {
            var ceva = new ProblemCurs6();
            Assert.AreEqual(20, ceva.nextInSequence(40));
        }
        [TestMethod()]
        public void nextInSequenceTest3()
        {
            var ceva = new ProblemCurs6();
            Assert.AreEqual(1, ceva.nextInSequence(1));
        }
    }
}