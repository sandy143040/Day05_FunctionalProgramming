using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Functional programming problem");
            Console.WriteLine("Please choose 1program from below option");
            Console.WriteLine("1.FlipCoin");
            Console.WriteLine("2.Leap Year");
            int option = Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1:
                    Console.Write("Enter the number of times to flip the coin: ");
                    int numberOfFlips = Convert.ToInt32(Console.ReadLine());

                    //Validate the input to ensure it is a positive integer
                    if (numberOfFlips < 0)
                    {
                        Console.WriteLine("Invalid input. Please enter a positive integer.");
                    }

                    CoinFlip coinFlip = new CoinFlip();
                    coinFlip.PerformFlips(numberOfFlips);
                    coinFlip.DisplayResults();
                    break;
                case 2:
                    Console.WriteLine("Enter a year: ");
                    int year = Convert.ToInt32(Console.ReadLine());
                    LeapYear leapYear = new LeapYear();
                    leapYear.CheckYear(year);
                    break;
                default:
                    Console.WriteLine("please choose program with given option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
