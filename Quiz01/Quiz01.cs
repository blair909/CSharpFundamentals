using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz01
{
    class Quiz01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Number = ");
            int numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Second Number =");
            int numberTwo = int.Parse(Console.ReadLine());
            double numberSol = numberOne / numberTwo;
            Console.WriteLine("Quotient of both:", numberSol);

            Console.ReadLine();
        }
    }
}
