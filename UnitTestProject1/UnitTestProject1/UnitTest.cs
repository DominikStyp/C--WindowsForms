using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 0;
            for (int i = 0; i < 10; i++)
            {
                x += i;
            }
            Assert.IsTrue(x > 100);
        }
    }
}
