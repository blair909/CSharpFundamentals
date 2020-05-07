using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MorningChallenges02
{
    public class Class1
    {
        //  Build a method that takes in a list of strings, and returns the list sorted.
        public List<string> derp()
        {
            List<string> rawr = new List<string>();
            rawr.Sort();
            return rawr;
        }
        //  Build a method that takes in a string and returns an integer that is equal to the length of the string. 
        public int derpo(string rolo)
        {
            rolo = "ahslsnsnaldpf";
            int bala = rolo.Length;
            return bala;
        }
        //  On a piece of paper or on your whiteboard desk write out a simple method.
        //  Label the following
        //  Return Type
        //  Both parts of the method signature
        //  Access modifier
        //  Body of the method
        public /*<=int*/ int /*<=return type*/ derpin/*<=method name*/(int y, int x)/*<=parameters*/
        {
            y = 100; /*<=body or local scope*/
            x = 50; /*<=body or local scope*/
            return (x & y);
        }
        //  Build a method that takes in a list of integers and returns the list sorted biggest to smallest.
        public List<int> Derpol()
        {
            List<int> alab = new List<int>()
            { 1, 3, 5, 7 };
            foreach (int num in alab)
            {
                alab.Sort();
                int small = alab[0];
                int big = alab[alab.Count - 1];
                return alab;
            }
            return alab;
        }
        //  Build a method that the user will input a string and the method should return the reverse of that string
        //  input: hello, output: olleh
        //  input: hello world, output: dlrow olleh
        public string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        //  Build a method that takes in a list of strings and returns the list but without any vowels (you can leave out ‘y’ if you want to).
        public List<string> Rem()
        {
            List<string> Rolof = new List<string>();
            foreach (string lal in Rolof)
            {
                if (lal.Contains("a", "e", "i", "o", "u"))
                {

                }
            }
        }
        //  Extra challenge: Make sure to take out ‘y’ if it is the vowel
        //  **Bonus- build out a test assembly and a test class to test all the methods you are building.
        //  ** Another bonus - write out by hand(on another paper or whiteboard) a few of the methods you have built.Mark the different parts of the method. 


    }
}
