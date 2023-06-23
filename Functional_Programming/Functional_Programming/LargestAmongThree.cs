using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming
{
    public class LargestAmongThree
    {
        public static int GetLargest(int num1, int num2, int num3)
        {
            if (num1 > num2 && num1 > num3)
                return num1;
            else if (num2 > num1 && num2 > num3)
                return num2;
            else
                return num3;
        }
    }
}
