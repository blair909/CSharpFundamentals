using System;
using System.Collections.Generic;

namespace MorningChallenges02
{
    public class KomodoInsuranceContentRepository
    {
        protected readonly List<KomodoInsuranceContent> _contentDirectory = new List<KomodoInsuranceContent>();
        public bool AddContentToDirectory(KomodoInsuranceContent content)
        {
            int startingCount = _contentDirectory.Count;
            _contentDirectory.Add(content);
            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }
        public List<KomodoInsuranceContent> GetContent()
        {
            return _contentDirectory;
        }
        public KomodoInsuranceContent GetContentByLastName(string lastName)
        {
            foreach (KomodoInsuranceContent content in _contentDirectory)
            {
                if (content.LastName.ToLower() == lastName.ToLower())
                {
                    return content;
                }
            }
            return null;
        }
        public bool UpdateExistingContent(string originalTitle, KomodoInsuranceContent updatedContent)
        {
            KomodoInsuranceContent oldContent = GetContentByLastName(originalTitle);
            if (oldContent != null)
            {
                oldContent.IDNumber = updatedContent.IDNumber;
                oldContent.Age = updatedContent.Age;
                oldContent.LastName = updatedContent.LastName;
                oldContent.EnrollmentDate = updatedContent.EnrollmentDate;
                oldContent.TotalMembershipYears = updatedContent.TotalMembershipYears;

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteExistingContent(KomodoInsuranceContent KomodoInsuranceContent)
        {
            bool deleteResult = _contentDirectory.Remove(KomodoInsuranceContent);
            return deleteResult;
        }
    }
}