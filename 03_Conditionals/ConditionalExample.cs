using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Conditionals
{
    [TestClass]
    public class ConditionalExample
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool userIsHungry = true;
            if (userIsHungry)
            {
                Console.WriteLine("Eat Something");
            }

            int hoursSpentStudying = 1;
            if (hoursSpentStudying < 16)
            {
                Console.WriteLine("Are you even trying");
            }
        }

        [TestMethod]
        public void IfElseStatements()
        {
            bool choresAreDone = true;
            if (choresAreDone)
            {
                Console.WriteLine("Have fun playing your video games!");
            }
            else
            {
                Console.WriteLine("Finish your chores! Please..");
            }

            //seven
            string input = "/";
            int totalHours = int.Parse(input);
            if (totalHours >= 8)
            {
                Console.WriteLine("Congrats");
            }
            else
            {
                Console.WriteLine("That sounds about right");
                if (totalHours < 3)
                {
                    Console.WriteLine("That's a big yikes");
                }
            }


            int age = 109;
            if (age > 17)
            {
                Console.WriteLine("You are an adult? Sorry about that.");
            }
            else
            {
                if (age > 6)
                {
                    Console.WriteLine("a child");
                }
                else if (age > 0)
                {
                    Console.WriteLine("get off the computer you hooligan");
                }
                else
                {
                    Console.WriteLine("You don't have an age? I am confusion");
                }
            }

            if (age > 65 || age < 18)
            {
                Console.WriteLine("Discount");
            }
        }

        enum WeekDay { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday}
        [TestMethod]
        public void SwitchCase()
        {
            int input = 1;

            switch (input)
            {
                case 1:
                    {
                        Console.WriteLine("Hello there");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("What are you doing?");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("This is the default. Yay");
                        break;
                    }
            }

            WeekDay today = WeekDay.Tuesday;
            switch (today)
            {
                case WeekDay.Monday:
                case WeekDay.Tuesday:
                case WeekDay.Wednesday:
                case WeekDay.Thursday:
                case WeekDay.Friday:
                    {
                        Console.WriteLine("Hope you're ready to code!");
                        break;
                    }
                case WeekDay.Saturday:
                case WeekDay.Sunday:
                    {
                        Console.WriteLine("Huzzah the weekend.");
                        break;
                    }
            }
        }

        [TestMethod]
        public void Ternary()
        {
            int age = 27;
            //(Condition/Boolean) ? trueResult : falseResult

            bool isAdult = (age > 17) ? true : false;

            int numOne = 10;
            int numTwo = (numOne == 10) ? 30 : 20;
        }
    } 
}
