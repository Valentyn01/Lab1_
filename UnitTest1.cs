using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()

        {
            int a = 1;
            int b = 2;
            int c = 3;
            int result = LAB1.Program.Swap1(a, b, c);
            Assert.AreEqual(2, 3, 1, result);
        }
    }
}



