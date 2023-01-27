using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Jalmoudy.String
{
    [TestClass]
    public class AdvanceReplaceZeroWithStarTestUnit
    {
        string RightInput = "01234567890";
        string RightInputResult = "*123456789*";

        string WrongInput = "O123456789O";
        string WrongInputResult = null;


        [TestMethod]
        public void ReplacingRightInputUsingArray()
        {
            var successfullArrayMethodReplacerResult = new AdvanceZeroWithStarReplacer(new ArrayMethodZeroWithStarReplacer())
                                                                .ReplaceZeroWithStar(RightInput);
            Assert.IsTrue(successfullArrayMethodReplacerResult.isSuccess);
            Assert.AreEqual(successfullArrayMethodReplacerResult.result, RightInputResult);
        }

        [TestMethod]
        public void ReplacingRightInputUsingDictionary()
        {
            var successfullDictionaryMethodReplacerResult = new AdvanceZeroWithStarReplacer(new DictionaryMethodZeroWithStarReplacer())
                                                                .ReplaceZeroWithStar(RightInput);
            Assert.IsTrue(successfullDictionaryMethodReplacerResult.isSuccess);
            Assert.AreEqual(successfullDictionaryMethodReplacerResult.result, RightInputResult);
        }

        [TestMethod]
        public void ReplacingWrongInputUsingArray()
        {
            var unsuccessfullArrayMethodReplacerResult = new AdvanceZeroWithStarReplacer(new ArrayMethodZeroWithStarReplacer())
                                                                .ReplaceZeroWithStar(WrongInput);
            Assert.IsTrue(unsuccessfullArrayMethodReplacerResult.isSuccess == false);
            Assert.AreEqual(unsuccessfullArrayMethodReplacerResult.result, WrongInputResult);
        }

        [TestMethod]
        public void ReplacingWrongInputUsingDictionary()
        {
            var unsuccessfullDictionaryMethodReplacerResult = new AdvanceZeroWithStarReplacer(new DictionaryMethodZeroWithStarReplacer())
                                                                .ReplaceZeroWithStar(WrongInput);
            Assert.IsTrue(unsuccessfullDictionaryMethodReplacerResult.isSuccess == false);
            Assert.AreEqual(unsuccessfullDictionaryMethodReplacerResult.result, WrongInputResult);
        }
    }
}
