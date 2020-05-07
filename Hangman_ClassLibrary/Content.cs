using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman_ClassLibrary
{
    public class Content
    {
        public string ActiveWord { get; set; }
        public Content() { }
        public Content(string activeWord)
        {
            ActiveWord = activeWord;
        }
    }
    public class Player
    {
        public string Name { get; set; }
        private int lifeCount = 6;
        public int LifeCount { get { return lifeCount; } set { lifeCount = value; } }
        public Player() { }
        public Player(string name, int lifeCount)
        {
            Name = name;
            LifeCount = lifeCount;
        }
    }
}
