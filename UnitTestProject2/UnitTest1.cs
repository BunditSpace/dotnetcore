using ClassLibraryISBN;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsValidISBN()
        {
            ISBN iSBN = new ISBN();
            string isnb10 = "0471958697";
            bool isvalid = iSBN.IsValidISBN(isnb10);
            Assert.IsTrue(isvalid);
        }

        [TestMethod]
        public void TestIsValidISBN_IgnoreSpace()
        {
            ISBN iSBN = new ISBN();
            string isnb10 = "0 471 60695 2";
            bool isvalid = iSBN.IsValidISBN(isnb10);
            Assert.IsTrue(isvalid);
        }

        [TestMethod]
        public void TestIsValidISBN_IgnoreHypen()
        {
            ISBN iSBN = new ISBN();
            string isnb10 = "99921-58-10-7";
            bool isvalid = iSBN.IsValidISBN(isnb10);
            Assert.IsTrue(isvalid);
        }

        [TestMethod]
        public void TestIsValidISBN_CheckDigit()
        {
            ISBN iSBN = new ISBN();
            string isnb10 = "0-470-84525-2";
            bool isvalid = iSBN.IsValidISBN(isnb10);
            Assert.IsTrue(isvalid);
        }



    }
}
