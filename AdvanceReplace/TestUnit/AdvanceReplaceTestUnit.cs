using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Jalmoudy.String
{
    [TestClass]
    public class AdvanceReplace_TestUnit
    {
        [TestMethod]
        public void ReplacingRightInputUsingArray()
        {
            var successfullReplaceResult = AdvanceReplacer.ReplaceZeroWithStar("01234567890", ReplaceingMethod.UsingArray);
            Assert.IsTrue(successfullReplaceResult.isSuccess);
            Assert.AreEqual(successfullReplaceResult.result, "*123456789*");
        }

        [TestMethod]
        public void ReplacingRightInputUsingDictionary()
        {
            var successfullReplaceResult = AdvanceReplacer.ReplaceZeroWithStar("01234567890", ReplaceingMethod.UsingDictionary);
            Assert.IsTrue(successfullReplaceResult.isSuccess);
            Assert.AreEqual(successfullReplaceResult.result, "*123456789*");
        }

        [TestMethod]
        public void ReplacingWrongInputUsingArray()
        {
            var unsuccessfullReplaceResult = AdvanceReplacer.ReplaceZeroWithStar("O123456789O", ReplaceingMethod.UsingArray);
            Assert.IsTrue(unsuccessfullReplaceResult.isSuccess == false);
            Assert.AreEqual(unsuccessfullReplaceResult.result, null);
        }

        [TestMethod]
        public void ReplacingWrongInputUsingDictionary()
        {
            var unsuccessfullReplaceResult = AdvanceReplacer.ReplaceZeroWithStar("O123456789O", ReplaceingMethod.UsingDictionary);
            Assert.IsTrue(unsuccessfullReplaceResult.isSuccess == false);
            Assert.AreEqual(unsuccessfullReplaceResult.result, null);
        }
    }
}
