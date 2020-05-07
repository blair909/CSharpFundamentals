using System;
using System.Collections.Generic;
using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentRepoTests
    {
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBool()
        {
            //Arrange
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repo = new StreamingContentRepository();
            //Act
            bool addResult = repo.AddContentToDirectory(content);
            //Assert
            Assert.IsTrue(addResult);
        }
        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectList()
        {
            //Arange
            StreamingContent testContent = new StreamingContent();
            StreamingContentRepository repo = new StreamingContentRepository();
            repo.AddContentToDirectory(testContent);

            //Act
            List<StreamingContent> testList = repo.GetContent();
            bool directoryHasContent = testList.Contains(testContent);
            //Assert
            Assert.IsTrue(directoryHasContent);
        }
        private StreamingContentRepository _repo;
        private StreamingContent _content;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepository();
            _content = new StreamingContent("Jack The Ripper", 123, new DateTime(1996, 8, 9), GenreType.Comedy, true);
            _repo.AddContentToDirectory(_content);
        }
        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectTitle()
        {
            StreamingContent searchResult = _repo.GetContentByTitle("Jack The Ripper");
            Assert.AreEqual(_content, searchResult);
        }

        [TestMethod]
        public void UpdatedExistingContent_ShouldReturnTrue()
        {
            StreamingContent newContent = new StreamingContent("Jack The Ripper", 324, new DateTime(1996, 8, 9), GenreType.Comedy, true);
            bool updateResult = _repo.UpdateExistingContent("Jack The Ripper", newContent);
            Assert.IsTrue(updateResult);
        }
        [TestMethod]
        public void DeleteContent_ShouldReturnTrue()
        {
            StreamingContent toBeDeleted = _repo.GetContentByTitle("Jack The Ripper");

            bool removeResult = _repo.DeleteExistingContent(toBeDeleted);
            Assert.IsTrue(removeResult);
        }
    }
}