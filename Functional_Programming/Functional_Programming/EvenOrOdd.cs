﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming
{
    public class EvenOrOdd
    {
        public void CheckEvenOdd()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if(n % 2 == 0)
            {
                Console.WriteLine("Given number is a Even Number");
            }
            else
            {
                Console.WriteLine("Given number is a Odd Number");
            }
        }
    }
}
