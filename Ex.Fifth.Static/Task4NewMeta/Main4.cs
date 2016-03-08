using NUnit.Framework;
using System;

namespace Ex.Fifth.Static
{
    partial class Presenter
    {
        [Test]
        public void ExtentionSubstring()
        {
            string myString = "array string my new string";

            Assert.AreEqual("array stri", myString.ExtentionSubstring(0, 10));
            Assert.AreEqual("tring my", myString.ExtentionSubstring(7, 8));
            Assert.AreEqual("", myString.ExtentionSubstring(26, 10));
            Console.WriteLine("Test 5 complit.");
        }

        [Test]
        public void ExtentionIndexOf()
        {
            string myString = "testStringopenWhile TestBework";

            string myString1 = "cndsjf_1_fmdjk";

            Assert.AreEqual(7, myString1.ExtentionIndexOf("1"));

            Assert.AreEqual(16, myString.ExtentionIndexOf("ile"));
            Assert.AreEqual(-1, myString.ExtentionIndexOf("qqqqq"));
            Assert.AreEqual(0, myString.ExtentionIndexOf("test"));
            Console.WriteLine("Test 6 complit.");
        }

        [Test]
        public void ExtentionReplace()
        {
            string myString = "replace this";

            Assert.AreEqual("replace NOT THIS", myString.ExtentionReplace("this", "NOT THIS"));
            Assert.AreEqual("replace this", myString.ExtentionReplace("right", "OTHER"));
            Assert.AreEqual("PERlace this", myString.ExtentionReplace("rep", "PER"));
            Console.WriteLine("Test 7 complit.");
        }
    }
}
