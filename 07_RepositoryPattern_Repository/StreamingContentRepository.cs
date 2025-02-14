﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _07_RepositoryPattern_Repository
{
    public class StreamingContentRepository
    {
        protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

        public bool AddContentToDirectory(StreamingContent content)
        {
            int startingCount = _contentDirectory.Count;
            _contentDirectory.Add(content);
            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        public List<StreamingContent> GetContent()
        {
            return _contentDirectory;
        }

        public StreamingContent GetContentByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }
            return null;
        }
        public bool UpdateExistingContent(string originalTitle, StreamingContent updatedContent)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle);
            if (oldContent != null)
            {
                oldContent.Title = updatedContent.Title;
                oldContent.RunTimeInMin = updatedContent.RunTimeInMin;
                oldContent.ReleaseDate = updatedContent.ReleaseDate;
                oldContent.IsFamilyFriendly = updatedContent.IsFamilyFriendly;
                oldContent.TypeOfGenre = updatedContent.TypeOfGenre;

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteExistingContent(StreamingContent streamingContent)
        {
            bool deleteResult = _contentDirectory.Remove(streamingContent);
            return deleteResult;
        }
    }
}