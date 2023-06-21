using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming
{
    public class Swaping
    {
        public static void Swap(int a, int b)
        {
            Console.WriteLine("before swaping: a = " + a + ", b = " + b);
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After swapping: a = " + a + ", b = " + b);
        }
    }
}
