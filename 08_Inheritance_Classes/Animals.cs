using System;
using System.Collections.Generic;
using System.Text;

namespace _08_Inheritance_Classes
{
    public enum DietType
    { Herbivore = 1, Omnivore, Carnivore }
    public class Animal
    {
        public int NumberOfLegs { get; set; }
        public bool HairFur { get; set; }
        public bool BreathesAir { get; set; }
        public DietType TypeOfDiet { get; set; }
        public Animal() { }

        public virtual void Move()
        {
            Console.WriteLine();
        }
        public Animal(string herbivore, string omnivore, string carnivore)
        {
            
        }

    }
}
