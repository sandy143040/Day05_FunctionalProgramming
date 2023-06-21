using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming
{
    public class QuotientAndRemainder
    {
        public void Calculation(int dividend, int divisor)
        {
           
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine($"Quotient = {quotient}");
            Console.WriteLine($"Remainder = {remainder}");
        }
    }
}
