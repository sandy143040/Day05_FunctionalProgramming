using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming
{
    public class PrimeFactors
    {
        public static void Factors(int n)
        {
            for (int i = 2; i * i <= n; i++)
            {
                while (n % i == 0)
                {
                    Console.Write("{0} ", i);
                    n /= i;
                }
            }
            if (n > 1)
            {
                Console.Write("{0} ", n);
            }
        }
    }
}
