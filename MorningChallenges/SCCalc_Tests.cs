using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MorningChallenges
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void SetTitle_ShouldSetCorrectString()
        {
            SCCalc content = new SCCalc();
            content.Title = "New Title";
            string expected = "New Title";
            string actual = content.Title;
            Assert.AreEqual(expected, actual);

        }
    }
}