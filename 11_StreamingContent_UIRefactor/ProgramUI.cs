﻿using _07_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace _11_StreamingContent_UIRefactor
{
    public class ProgramUI
    {
        private readonly IConsole _console;
        private readonly StreamingContentRepository _streamingRepo = new StreamingContentRepository();

        public ProgramUI(IConsole console)
        {
            _console = console;
        }
        public void Run()
        {
            SeedContentList();
            RunMenu();
        }

        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                _console.Clear();
                _console.WriteLine("Enter the number of the option you'd like to select: \n" +
                    "1) Show all streaming content \n" +
                    "2) Find streaming content by title \n" +
                    "3) Add new streaming content \n" +
                    "4) Remove streaming content \n" +
                    "5) Update \n" +
                    "6) Exit");
                string userInput = _console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        {
                            //Show All
                            ShowAll();
                            break;
                        }
                    case "2":
                        {
                            //Show by title
                            ShowByTitle();
                            break;
                        }
                    case "3":
                        {
                            //Add new content
                            CreateNewContent();
                            break;
                        }
                    case "4":
                        {
                            //delete content
                            RemoveContent();
                            break;
                        }
                    case "5":
                        {
                            //Exit
                            continueToRun = false;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
        }

        private void CreateNewContent()
        {
            _console.Clear();
            StreamingContent content = new StreamingContent();
            //public string Title { get; set; }
            //public int RunTimeInMin { get; set; }
            //public DateTime ReleaseDate { get; set; }
            //public GenreType TypeOfGenre { get; set; }
            //public bool IsFamilyFriendly { get; set; }
            _console.Write("Pease enter a title:  ");
            content.Title = _console.ReadLine();

            _console.Write("Please enter the runtime in minutes:  ");
            content.RunTimeInMin = int.Parse(_console.ReadLine());

            _console.WriteLine("Select a Genre: \n" +
                "1) Horror \n" +
                "2) SciFi \n" +
                "3) Bromance \n" +
                "4) Action \n" +
                "5) Fantasy \n" +
                "6) Comedy \n" +
                "7) Drama \n" +
                "8) Crime");
            //var test = Enum.GetValues(typeof(GenreType));
            //var i = 1;
            //foreach (var value in test)
            //{
            //    _console.WriteLine($"{i}) {value}");
            //    i += 1;
            //}
            //_console.ReadLine();
            string genreChoice = _console.ReadLine();
            int genreId = int.Parse(genreChoice);
            content.TypeOfGenre = (GenreType)genreId;

            _console.WriteLine("Is this content family friendly? (enter true or false)");
            string fBool = _console.ReadLine().ToLower();
            //Convert.ToBoolean(fBool);
            switch (fBool)
            {
                case "true":
                    {
                        content.IsFamilyFriendly = true;
                        break;
                    }
                case "false":
                    {
                        content.IsFamilyFriendly = false;
                        break;
                    }
            }
            _console.WriteLine("What is the release date of this content? \n" +
                "use format: YYYY,MM,DD \n" +
                "Example: 1943,01,24");
            string rDate = _console.ReadLine();
            content.ReleaseDate = DateTime.Parse(rDate);

            bool added = _streamingRepo.AddContentToDirectory(content);
            if (added)
            {
                _console.WriteLine("Your Content has been added \n" +
                    "Press any key to continue");
                _console.ReadKey();
            }
            else
            {
                _console.WriteLine("There has been an error, please try again");
                _console.ReadKey();
            }
        }
        private void ShowAll()
        {
            _console.Clear();
            List<StreamingContent> listOfContent = _streamingRepo.GetContent();
            foreach (StreamingContent content in listOfContent)
            {
                DisplayContent(content);
            }
            _console.WriteLine("Press any key to continue...");
            _console.ReadKey();

        }
        private void DisplayContent(StreamingContent content)
        {

            _console.WriteLine($"Title: {content.Title} \n" +
                $"Genre: {content.TypeOfGenre} \n" +
                $"This content is family friendly: {content.IsFamilyFriendly} \n" +
                $"Runtime(in min): {content.RunTimeInMin} \n" +
                $"Release Date: {content.ReleaseDate}");
        }
        private void ShowByTitle()
        {
            _console.Clear();
            _console.WriteLine("Please enter a title: ");
            string title = _console.ReadLine();
            StreamingContent foundContent = _streamingRepo.GetContentByTitle(title);
            if (foundContent != null)
            {
                DisplayContent(foundContent);
            }
            else
            {
                _console.WriteLine("Invalid title. Could not find any results");
            }
            _console.WriteLine("Press any key to continue");
            _console.ReadKey();
        }
        private void RemoveContent()
        {
            _console.WriteLine("Which item would you like to remove?...");
            List<StreamingContent> contentList = _streamingRepo.GetContent();
            int count = 0;
            foreach (StreamingContent content in contentList)
            {
                count++;
                _console.WriteLine($"{count} - {content.Title}");
            }
            int targetContentId = int.Parse(_console.ReadLine());
            int targetIndex = targetContentId - 1;
            if (targetIndex >= 0 && targetIndex < contentList.Count)
            {
                StreamingContent desiredContent = contentList[targetIndex];
                if (_streamingRepo.DeleteExistingContent(desiredContent))
                {
                    _console.WriteLine($"{desiredContent.Title} has been removed");
                }
                else
                {
                    _console.WriteLine("I'm sorry, Dave. I'm afraid I can't do that.");
                }
            }
            else
            {
                _console.WriteLine("No content had that ID.");
            }
            _console.WriteLine("Press any key to continue....");
            _console.ReadKey();
        }


        private void SeedContentList()
        {
            StreamingContent aladdin = new StreamingContent("Aladdin", 123, new DateTime(2020, 02, 01), GenreType.Crime, true);
            _streamingRepo.AddContentToDirectory(aladdin);
            StreamingContent jack = new StreamingContent("Jack", 45, new DateTime(1345, 05, 05), GenreType.Fantasy, false);
            _streamingRepo.AddContentToDirectory(jack);
            StreamingContent bigHeroSix = new StreamingContent("Big Hero Six", 236, new DateTime(1934, 02, 02), GenreType.Bromance, true);
            _streamingRepo.AddContentToDirectory(bigHeroSix);
            StreamingContent pB = new StreamingContent("Princess Bride", 9285, new DateTime(1209, 03, 03), GenreType.Action, true);
            _streamingRepo.AddContentToDirectory(pB);
        }
    }
}