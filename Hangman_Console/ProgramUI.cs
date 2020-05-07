using Hangman_ClassLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_ConsoleApp
{
    class ProgramUI
    {
        public static void Main(string[] args)
        { }
        private readonly Repository _repository = new Repository();
        private readonly PlayerRepo _playerRepo = new PlayerRepo();
        public void Run()
        {
            RunMenu();
        }
        public void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Hangman! \n" +
                    "1) Begin a Game. \n");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        {
                            StartPlaying();
                            break;
                        }
                    default:
                        {
                            continueToRun = false;
                            break;
                        }
                }
            }
        }
        private void StartPlaying()
        {
            Console.WriteLine("Now it begins... Good luck.");
            PlayingTheGame();
        }
        private void PlayingTheGame()
        {
            PullWords();
            NumberofLetters();

        }
        private void PullWords()
        {

        }
        private void NumberofLetters()
        {

        }
    }
}