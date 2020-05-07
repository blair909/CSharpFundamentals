using System;
using System.Collections.Generic;
using System.Text;

namespace _07_RepositoryPattern_Repository
{
    class Shows : StreamingContent
    {
        public int SeasonCount { get; set; }
        public int EpisodeCount { get; set; }
        public double AverageRunTime { get; set; }
        public List<Episode> Episodes { get; set; }
    }
    public class Episode
    {
        public string Title { get; set; }
        public double runTime { get; set; }
        public int SeasonNumber { get; set; }
    }
}
