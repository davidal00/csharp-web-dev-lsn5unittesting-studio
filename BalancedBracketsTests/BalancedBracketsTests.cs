using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }

        // TODO: test1

        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        // TODO: test2

        [TestMethod]
        public void ReversedBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        // TODO: test3

        [TestMethod]
        public void NullReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }

        // TODO: test4

        [TestMethod]
        public void OnlyLeftBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }

        // TODO: test5

        [TestMethod]
        public void OnlyRightBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));
        }

        // TODO: test6

        [TestMethod]
        public void BalancedBracketsWithTextBetweenReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode]"));
        }

        // TODO: test7

        [TestMethod]
        public void BalancedBracketsWithTextBetweenAndToTheLeftReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Launch[Code]"));
        }

        // TODO: test8

        [TestMethod]
        public void BalancedBracketsWithTextToTheRightReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]LaunchCode"));
        }

        // TODO: test9

        [TestMethod]
        public void TwoSetsOfBalancedBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]LaunchCode[]"));
        }

        // TODO: test10

        [TestMethod]
        public void NestedBalancedBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[LaunchCode]]"));
        }

        // TODO: test11

        [TestMethod]
        public void OnlyLeftBracketsWithTextReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[LaunchCode"));
        }

        // TODO: test12

        [TestMethod]
        public void OnlyRightBracketsWithTextReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("LaunchCode]"));
        }

    }
}
