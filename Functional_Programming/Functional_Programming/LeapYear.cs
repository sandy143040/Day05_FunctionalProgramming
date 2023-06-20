using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming
{
    public class LeapYear
    {
        public void CheckYear(int year)
        {
            
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("Year is a leap year");
            }
            else
            {
                Console.WriteLine("Year is not a leap year");
            }
        }
    }
}
