using System;
using System.Collections.Generic;
using GoldBadge02_ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GoldBadge02_UnitTest
{
    [TestClass]
    public class KomodoClaimsRepoTest
    {
        [TestMethod]
        public void AddContentToDirectory_ShouldGetCorrectBool()
        {
            KomodoClaimsContent testContent = new KomodoClaimsContent();
            KomodoClaimsRepo repo = new KomodoClaimsRepo();

            bool addResult = repo.AddClaimToDirectory(testContent);
            Assert.IsTrue(addResult);
        }
        [TestMethod]
        public void GetAllDirectory_ShouldReturnCorrectList()
        {
            KomodoClaimsContent testContent = new KomodoClaimsContent();
            KomodoClaimsRepo repo = new KomodoClaimsRepo();
            repo.AddClaimToDirectory(testContent);

            Queue<KomodoClaimsContent> testList = repo.GetAllClaims();
            bool directoryHasContent = testList.Contains(testContent);
            Assert.IsTrue(directoryHasContent);
        }
        [TestMethod]
        public void LookAtNextClaim_ShouldReturnCorrectItem()
        {
            KomodoClaimsContent testItem = new KomodoClaimsContent();
            KomodoClaimsRepo repo = new KomodoClaimsRepo();
            repo.AddClaimToDirectory(testItem);

            Queue<KomodoClaimsContent> testQueue = repo.LookAtNextClaim();
            bool directoryHasItem = testQueue.Contains(testItem);
            Assert.IsTrue(directoryHasItem);
        }
        [TestMethod]
        public void ProcessNextClaim_ShouldReturnCorrectDequeuedItem()
        {
            KomodoClaimsContent testItem = new KomodoClaimsContent();
            KomodoClaimsRepo repo = new KomodoClaimsRepo();
            repo.AddClaimToDirectory(testItem);

            Queue<KomodoClaimsContent> testQueue = repo.ProcessNextClaim();
            bool directoryDequeuedItem = testQueue.Contains(testItem);
            Assert.IsTrue(directoryDequeuedItem);
        }
    }
}