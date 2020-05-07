using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MorningChallenges
{
    [TestClass]
    public class SCCalcRepositoryTests
    {
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBool()
        {
            //Arrange
            SCCalc content = new SCCalc();
            SCCalcRepository repo = new SCCalcRepository();
            //Act
            bool addResult = repo.AddContentToDirectory(content);
            //Assert
            Assert.IsTrue(addResult);
        }
        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectList()
        {
            //Arange
            SCCalc testContent = new SCCalc();
            SCCalcRepository repo = new SCCalcRepository();
            repo.AddContentToDirectory(testContent);

            //Act
            List<SCCalc> testList = repo.GetContent();
            bool directoryHasContent = testList.Contains(testContent);
            //Assert
            Assert.IsTrue(directoryHasContent);
        }
    }
}