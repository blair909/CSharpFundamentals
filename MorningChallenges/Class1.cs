using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorningChallenges
{
    class Class1
    {
        public int Difference(int valueOne, int valueTwo)
        {
            valueOne = 50;
            valueTwo = 30;
            int valueSol = valueOne - valueTwo;
            return valueSol;
        }
        public string Output(string strOne, string strTwo, string strSol)
        {
            Console.WriteLine("Enter a string.");
            strOne = Console.ReadLine();
            Console.WriteLine("Enter another string.");
            strTwo = Console.ReadLine();
            strSol = (strOne + strTwo);
            return (strSol);
                Console.WriteLine("Looks like you said: ", strSol);
        }

        public static void Main()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much money do you make in a year?");
            if (number >= 1000 && number <= 10000)
            {

            }

        }

    }
}
