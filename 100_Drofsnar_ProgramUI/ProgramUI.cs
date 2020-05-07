using _100_Drofsnar_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _100_Drofsnar_Program
{

    class ProgramUI
    {
        public class Bird
        {
            public string Name { get; set; }
            public int Value { get; set; }

            List<Bird> bird = new List<Bird>();
            bird.Add(new Bird("Bird", 10));

            public Bird(string name, int points)
            {
                Drofsnar drofsnarAlpha = new Drofsnar(3, 5000);
                Bird birdAlpha = new Bird("Bird", 10);
                Bird birdBeta = new Bird("CrestedIbis", 100);
                Bird birdGamma = new Bird("GreatKiskudee", 300);
                Bird birdDelta = new Bird("RedCrossbill", 500);
                Bird birdEpsilon = new Bird("Red-neckedPhalarope", 700);
                Bird birdZeta = new Bird("EveningGrosbeak", 1000);
                Bird birdEta = new Bird("GreaterPrairieChicken", 2000);
                Bird birdTheta = new Bird("IcelandGull", 3000);
                Bird birdIota = new Bird("Orange-BelliedParrot", 5000);

                Name = name;
                Value = points;
            }
        }
        public class Enemy
        {
            public string Name { get; set; }
            public int Damage { get; set; }
            public Enemy(string name, int damage)
            {
                Name = name;
                Damage = damage;
            }
        }
        public class Drofsnar
        {
            public int Lives { get; set; }
            public int Points { get; set; }
            public Drofsnar(int lives, int points)
            {
                Lives = 3;
                Points = 5000;
            }
            public void AddPoints(Bird birdAlpha)
            {
                Points += birdAlpha.Value;
            }
        }
        //The attached CSV file(game-sequence.txtPreview the document) contains the list of the entities that Drofsnar meets during the game in order of appearance.Download the file and include it in your project.
        //Your code should read from the file and manage the specific collision with each entity by scoring points and lives.This means you'll need to be able to check what the next item Drofsnar interacts with and evaluate the appropriate value.
        //Assume that Drofsnar starts the game with:
        //5000 points
        //3 lives
        //At the end of the game print out the total points and total remaining lives.
        //Try to adopt an OOP (object oriented programming) approach.
        class Application
        {
            static void Main(string[] args)
            {
                string rawText = File.ReadAllText(@"C:\Users\Carson Blair\source\repos\CSharpFundo\100_Drofsnar_ProgramUI\game-sequence.txt");
                string[] encounters = rawText.Split(',');
                foreach (var encounter in encounters)
                {
                    if (birdAlpha.Name == encounter)
                    {
                        drofsnarAlpha.AddPoints(birdAlpha);
                        Console.WriteLine(drofsnarAlpha.Points);
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}