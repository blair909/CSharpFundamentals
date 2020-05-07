using System;
using System.Collections.Generic;
using System.Text;

namespace _07_RepositoryPattern_Repository
{
    class MovieAndShowRepo : StreamingContentRepository
    {
        public Shows GetShowByTitle(string title)
        {
            foreach(StreamingContent content in _contentDirectory)
            {
                if(content.Title.ToLower() == title.ToLower() && content.GetType() == typeof(Shows))
                {
                    return (Shows)content;
                }
            }
            return null;
        }
        public List<Shows> GetAllShows()
        {
            List<Shows> allShows = new List<Shows>();
            foreach(StreamingContent content in _contentDirectory)
            {
                if (content is Shows)
                {
                    allShows.Add((Shows)content);
                }
            }
            return allShows;
        }
        public Movies GetMoviesByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower() && content.GetType() == typeof(Movies))
                {
                    return (Movies)content;
                }
            }
            return null;
        }
        public List<Movies> GetAllSMovies()
        {
            List<Movies> allMovies = new List<Movies>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Movies)
                {
                    allMovies.Add((Movies)content);
                }
            }
            return allMovies;
        }
    }
}
