using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorningChallenges
{
    class SCCalc
    {
        public int Product{ get; set; }
        public int Sum { get; set; }
        public int Quotient { get; set; }
        public int Difference { get; set; }
        public SCCalc () { }
        public SCCalc (int product, int sum, int quotient, int difference)
        {
            Product = product;
            Sum = sum;
            Quotient = quotient;
            Difference = difference;
        }
    }
}
