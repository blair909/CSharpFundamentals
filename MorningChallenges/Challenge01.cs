using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MorningChallenges
{
    [TestClass]
    public class Challenge01
    {
        [TestMethod]
        public void TestMethod1()
        {
            string text01 = "Supercalifragilisticexpialidocious";
            Console.WriteLine(text01.Length);
            char[] superCal = text01.ToCharArray();
            Console.WriteLine("Individual characters from given string");
            foreach (char i in superCal)
            {
                Console.WriteLine(i);
            }

            foreach (char i in superCal)
            {
                if (i == 'i')
                {
                    Console.WriteLine(i);
                }
                else if (i =='l')
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine("not i or l");
                }
            }
        }
        //After you determine if the letter is or isn't, i determine if the letter is 'L'. If that is true, print that letter. Change the else message to make sense.

    }
}
