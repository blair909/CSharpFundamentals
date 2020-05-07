using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Quiz
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("First Number = ");
            int numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Second Number =");
            int numberTwo = int.Parse(Console.ReadLine());
            double numberSol = numberOne / numberTwo;
            Console.WriteLine("Quotient of both:", numberSol);
        }
    }
}