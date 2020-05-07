using System;
using System.Collections.Generic;

namespace Hangman_ClassLibrary
{
    public class Repository
    {
        protected readonly List<Content> _wordDirectory = new List<Content>();
        public List<string> pullWords = new List<string>() { "Car ", "Fish", "House", "River", "Dog", "Bat", "Cat", "Rat", "Bike", "King", "\n" +
            "cycle", "Boggle", "Injury", "Funny", "Jogging", "Joking", "Puppy", "Quiz", "Scratch", "Subway", "\n"+
            "Zombie", "Witchcraft", "Syndrome", "Razzmatazz", "Grogginess", "Askew", "Croquet", "Pspionage", "Jiujitsu", "Xylophone" };
        public string StartPlaying(Content pullWords)
        {
            int startingCount = _wordDirectory.Count;
            _wordDirectory.Add(pullWords);
            string levelSelected = (_wordDirectory.Count == startingCount) ? "You have now selected your level" : "Please select a level";
            return levelSelected;
        }
        public string PullWords()
        {
            var random = new Random();
            int index = random.Next(pullWords.Count);
            string ActiveWord = pullWords[index].ToString();
            return ActiveWord;
        }
        public int NumberOfLetters(string ActiveWords)
        {
            char[] letters = ActiveWords.ToCharArray();
            int number = letters.Length;
            return number;
        }
        public string PlayingTheGame(string activeWord)
        {
            char[] letter = new char[activeWord.Length];
            for (int w = 0; w < letter.Length; w++)
            {
                letter[w] = '_';
            }
            for (int w = 0; w < letter.Length; w++)//number of letters via underscores
            {
                Console.WriteLine(letter[w] + " ");
            }
            Console.WriteLine();
            int count = 0;
            do
            {
                ////UI requesting a guess.
                char input = Console.ReadLine().ToCharArray()[0];
                for (int w = 0; w < activeWord.Length; w++)
                {
                    if (activeWord[w] == input)///if correct
                    {
                        count++; ///update count to check upon exit
                        letter[w] = input; ///replacing the dash
                        for (int l = 0; l < activeWord.Length; l++)
                        {
                            Console.WriteLine(letter[l] + " ");
                        }
                    }
                }
                Console.WriteLine();
            }
            while (count < activeWord.Length);
            string rightString = "You guessed it right.";
            return rightString;
        }
    }
    public class PlayerRepo
    {
        //create the name space in UI with CW
    }
}