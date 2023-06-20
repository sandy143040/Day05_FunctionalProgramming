using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming
{
    public class PowerOfTwo
    {
        public static void PrintPowersOfTwo(int N)
        {
            int i = 0;
            int power = 1;

            // Print the powers of 2 until i equals N
            while (i <= N)
            {
                Console.WriteLine($"2^{i} = {power}");
                power *= 2;
                i++;
            }
        }
    }
}
