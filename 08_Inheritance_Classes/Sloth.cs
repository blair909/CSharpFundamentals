using System;
using System.Collections.Generic;
using System.Text;

namespace _08_Inheritance_Classes
{
    public class Sloth : Animal
    {
        public bool IsSlow
        { get { return true; } }
        public override void Move()
        {
            Console.WriteLine("The sloth moves slowly!");
        }

        public class Megatherium : Sloth
        {
            public override void Move()
                {
                Console.WriteLine("Megatherium uses Move! It's not super effective.");
                }
        }
    }
}
