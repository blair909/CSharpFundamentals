using System;
using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StreamingContentTests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void SetTitle_ShouldSetCorrectString()
        {
            StreamingContent content = new StreamingContent();
            content.Title = "New Title";
            string expected = "New Title";
            string actual = content.Title;
            Assert.AreEqual(expected, actual);

        }
    }
}
