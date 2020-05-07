using System;
using System.Collections.Generic;
using System.Text;

namespace _07_RepositoryPattern_Repository
{
    public class Movies : StreamingContent
    {
        public bool IsSequel { get; set; }
        public Movies() { }
        public Movies(string title, int runTime, DateTime releaseDate, GenreType type, bool isFamilyFriendly, bool isSequel) : base(title, runTime, releaseDate, type, isFamilyFriendly)
        {
            IsSequel = isSequel;
        }
    }
}
