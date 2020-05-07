using System;

namespace _100_Drofsnar_RepositoryPattern_Repository
{
    public enum BirdType
    {
        Bird = 10,
        CrestedIbis = 100,
        GreatKiskudee = 300,
        RedCrossbill = 500,
        RedneckedPhalarope = 700,
        EveningGrosbeak = 1000,
        GreaterPrairieChicken = 2000,
        IcelandGull = 3000,
        OrangeBelliedParrot = 5000,
        VulnerableBirdHunters01 = 200,
        VulnerableBirdHunters02 = 400,
        VulnerableBirdHunters03 = 800,
        VulnerableBirdHunters04 = 1600,
    }

    public class Drofsnar
    {
        public int Lives { get; set; }
        public int Points { get; set; }
        public Drofsnar() { }
        public Drofsnar(int lives, int points)
        {
            Lives = lives;
            Points = points;
        }
    }
}
