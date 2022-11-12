using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using term;

namespace dynterm_unittest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            if(Assert.Equals(0,0))
            {
                // Nothing happens.
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}
