using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlphabetComplete;

namespace AlphabetCompleteUnitTests
{
    [TestClass]
    public class AlphabetCompleteUnitTest
    {
        [TestMethod]
        public void TestEmptyAndNull()
        {
            AlphabetCheck ac = new AlphabetCheck();
            
            bool result = ac.ContainsEntireAlphabet(string.Empty);
            Assert.AreEqual(false, result);

            ac.ContainsEntireAlphabet(null);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestShortString()
        {
            AlphabetCheck ac = new AlphabetCheck();

            bool result = ac.ContainsEntireAlphabet("abcde");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestLowers()
        {
            AlphabetCheck ac = new AlphabetCheck();

            bool result = ac.ContainsEntireAlphabet("abcdefghijklmnopqrstuvwxyz");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestUppers()
        {
            AlphabetCheck ac = new AlphabetCheck();

            bool result = ac.ContainsEntireAlphabet("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMix()
        {
            AlphabetCheck ac = new AlphabetCheck();

            bool result = ac.ContainsEntireAlphabet("aBcDeFgHiJkLmNoPqRsTuVwXyZ");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestAllButOne()
        {
            AlphabetCheck ac = new AlphabetCheck();

            // Missing u
            bool result = ac.ContainsEntireAlphabet("aBcDeFgHiJkLmNoPqRsTVwXyZ");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestOverlyMixed()
        {
            AlphabetCheck ac = new AlphabetCheck();

            bool result = ac.ContainsEntireAlphabet("!@$%^^*aBc%^&DeFgHiJk$%^@#LmNoPq%^*&$RsTuVwXyZ");
            Assert.AreEqual(true, result);
        }

    }
}
