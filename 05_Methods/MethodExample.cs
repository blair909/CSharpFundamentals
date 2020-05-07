﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Methods
{
    [TestClass]
    public class MethodExample
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }
        public int AddTwoNumbers(int numOne, int numTwo)
        {
            var sum = numOne + numTwo;
            return sum;
        }
        public double AddTwoNumbers(double numOne, double numTwo)
        {
            double sum = numOne + numTwo;
            return sum;
        }

        private int CalculateAge(DateTime birthdate)
        {
            TimeSpan ageSpan = DateTime.Now - birthdate;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;
            int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
        }

        [TestMethod]
        public void TestMethod1()
        {
            SayHello("Banana");
            SayHello("Bob");
            int sum = AddTwoNumbers(42, 75);
            Console.WriteLine(sum);

            double doubleSum = AddTwoNumbers(12.2, 42.6);

            int myAge = CalculateAge(new DateTime(1901, 05, 23));
            Console.WriteLine(("My age: ") + myAge);
        }
    }
}
