using _07_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_Console
{
    class ProgramUI
    {
        private readonly StreamingContentRepository _streamingRepo = new StreamingContentRepository();
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
                Console.Clear();
                Console.WriteLine("Enter the number of the option you'd like to select: \n" +
                    "1) Show all streaming content \n" +
                    "2) Find streaming content by title \n" +
                    "3) Add new streaming content \n" +
                    "4) Remove streaming content \n" +
                    "5) Update existing content \n" +
                    "6) Exit");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        {
                            ShowAll();
                            break;
                        }
                    case "2":
                        {
                            ShowByTitle();
                            break;
                        }
                    case "3":
                        {
                            CreateNewContent();
                            break;
                        }
                    case "4":
                        {
                            RemoveContent();
                            break;
                        }
                    case "5":
                        {
                            UpdateExistingContent();
                            break;
                        }
                    case "6":
                        {
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
            Console.Clear();
            StreamingContent content = new StreamingContent();
            //  public string Title { get; set; }
            //  public int RunTimeInMin { get; set; }
            //  public DateTime ReleaseDate { get; set; }
            //  public GenreType TypeOfGenre { get; set; }
            //  public bool IsFamilyFriendly { get; set; }
            Console.Write("Please enter a title: ");
            content.Title = Console.ReadLine();

            Console.Write("Please enter the runtime in minutes: ");
            content.RunTimeInMin = int.Parse(Console.ReadLine());
            {
                //  Horror,
                //  SciFi,
                //  Bromance,
                //  Action,
                //  Fantasy,
                //  Comedy,
                //  Drama,
                //  Crime,
                Console.WriteLine("Select a Genre: \n" +
                "1) Horror \n" +
                "2) SciFi \n" +
                "3) Bromance \n" +
                "4) Action \n" +
                "5) Fantasy \n" +
                "6) Comedy \n" +
                "7) Drama \n" +
                "8) Crime \n");

                string genreChoice = Console.ReadLine();
                int genreId = int.Parse(genreChoice);
                content.TypeOfGenre = (GenreType)genreId;

                Console.WriteLine("Is this content family friendly? (enter true or false)");
                string fbol = Console.ReadLine().ToLower();

                switch (fbol)
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
                Console.WriteLine("What is the release date of this content \n?" +
                    "use format: year, month, day \n" +
                    "Example: 1943, 01, 24");
                string rDate = Console.ReadLine();
                content.ReleaseDate = DateTime.Parse(rDate);
                bool added = _streamingRepo.AddContentToDirectory(content);
                if (added)
                {
                    Console.WriteLine("Your Content has been added \n" +
                        "Press any key to continue");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("There has been an error, please try again");
                    Console.ReadKey();
                }
            }
        }
        public void ShowAll()
        {
            Console.Clear();
            List<StreamingContent> listOfContent = _streamingRepo.GetContent();
            foreach (StreamingContent content in listOfContent)
            {
                DisplayContent(content);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        private void DisplayContent(StreamingContent content)
        {
            Console.WriteLine($"Title: {content.Title} \n" +
                $"Genre: {content.TypeOfGenre} \n" +
                $"This content is family friendly: {content.IsFamilyFriendly} \n" +
                $"Runtime (in min): {content.RunTimeInMin} \n" +
                $"Release Date: {content.ReleaseDate}");
        }
        private void ShowByTitle()
        {
            Console.Clear();
            Console.WriteLine("Please enter a titile: ");
            string title = Console.ReadLine();
            StreamingContent foundContent = _streamingRepo.GetContentByTitle(title);
            if (foundContent != null)
            {
                DisplayContent(foundContent);
            }
            else
            {
                Console.WriteLine("Invalid title. Could not find ny results");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
        private void RemoveContent()
        {
            Console.WriteLine("Which item would you like to remove?...");
            List<StreamingContent> contentList = _streamingRepo.GetContent();
            int count = 0;
            foreach (StreamingContent content in contentList)
            {
                count++;
                Console.WriteLine($"{count}. {content.Title}");
            }
            int targetContentId = int.Parse(Console.ReadLine());
            int targetIndex = targetContentId - 1;
            if (targetIndex >= 0 && targetIndex < contentList.Count)
            {
                StreamingContent desiredContent = contentList[targetIndex];
                if (_streamingRepo.DeleteExistingContent(desiredContent))
                {
                    Console.WriteLine($"{desiredContent.Title} has been removed.");
                }
                else
                {
                    Console.WriteLine("I'm sorry, Dave. I'm afraid I can't do that.");
                }
            }
            else
            {
                Console.WriteLine("No content had that ID.");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        private void SeedContentList()
        {
            StreamingContent aladin = new StreamingContent("Aladin", 123, new DateTime(2020, 02, 01), GenreType.Crime, true);
            _streamingRepo.AddContentToDirectory(aladin);
            StreamingContent jack = new StreamingContent("Jack", 45, new DateTime(1345, 05, 05), GenreType.Fantasy, false);
            _streamingRepo.AddContentToDirectory(jack);
            StreamingContent bigHeroSix = new StreamingContent("Big Hero Six", 236, new DateTime(1934, 02, 02), GenreType.Bromance, true);
            _streamingRepo.AddContentToDirectory(bigHeroSix);
            StreamingContent p8 = new StreamingContent("Princess Bride", 9285, new DateTime(1209, 03, 03), GenreType.Action, true);
            _streamingRepo.AddContentToDirectory(p8);
        }
        private void UpdateExistingContent()
        {
            Console.Clear();
            Console.WriteLine("Which item would you like to update...?");
            List<StreamingContent> contentList = _streamingRepo.GetContent();
            int count = 0;
            StreamingContent content = new StreamingContent();
            string oldTitle = Console.ReadLine();
            StreamingContent newContent = new StreamingContent();
            Console.WriteLine("Please enter a new title name.");
            newContent.Title = Console.ReadLine();
            //  public string Title { get; set; }
            //  public int RunTimeInMin { get; set; }
            //  public DateTime ReleaseDate { get; set; }
            //  public GenreType TypeOfGenre { get; set; }
            //  public bool IsFamilyFriendly { get; set; }

            Console.WriteLine("Please enter the runtime in minutes: ");
            newContent.RunTimeInMin = int.Parse(Console.ReadLine());
            {
                //  Horror,
                //  SciFi,
                //  Bromance,
                //  Action,
                //  Fantasy,
                //  Comedy,
                //  Drama,
                //  Crime,
                Console.WriteLine("Select a Genre: \n" +
                "1) Horror \n" +
                "2) SciFi \n" +
                "3) Bromance \n" +
                "4) Action \n" +
                "5) Fantasy \n" +
                "6) Comedy \n" +
                "7) Drama \n" +
                "8) Crime \n");

                string genreChoice = Console.ReadLine();
                int genreId = int.Parse(genreChoice);
                newContent.TypeOfGenre = (GenreType)genreId;

                Console.WriteLine("Is this content family friendly? (enter true or false)");
                string derpo = Console.ReadLine().ToLower();

                switch (derpo)
                {
                    case "true":
                        {
                            newContent.IsFamilyFriendly = true;
                            break;
                        }
                    case "false":
                        {
                            newContent.IsFamilyFriendly = false;
                            break;
                        }
                }
                Console.WriteLine("What is the release date of this content \n?" +
                    "use format: year, month, day \n" +
                    "Example: 1943, 01, 24");
                string rDate = Console.ReadLine();
                newContent.ReleaseDate = DateTime.Parse(rDate);
                bool updated = _streamingRepo.AddContentToDirectory(content);
                if (updated)
                {
                    Console.WriteLine("Your Content has been updated \n" +
                        "Press any key to continue");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("YA DUN F'D UP A-ARON, please try again");
                    Console.ReadKey();
                }
            }

            _streamingRepo.UpdateExistingContent(oldTitle, newContent);
        }
    }
}
