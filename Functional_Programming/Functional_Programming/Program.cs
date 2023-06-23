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
       
            while (true)
            {
                Console.WriteLine("Please choose 1program from below option");
                Console.WriteLine("1.FlipCoin");
                Console.WriteLine("2.Leap Year");
                Console.WriteLine("3.PowerOfTwo Table");
                Console.WriteLine("4.Harmonic Number");
                Console.WriteLine("5.Prime Factors");
                Console.WriteLine("6.QuotientAndRemainder");
                Console.WriteLine("7.Swaping Numbers");
                Console.WriteLine("8.Even or Odd");
                Console.WriteLine("9.Vowel or Consonent");
                Console.WriteLine("10.Largest Among_3 Num");
                Console.WriteLine("0.Exit");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
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
                    case 3:
                        Console.Write("Enter the power value (N): ");
                        int N = Convert.ToInt32(Console.ReadLine());

                        // Check if N is within the valid range
                        if (N < 0 || N >= 31)
                        {
                            Console.WriteLine("Invalid input! N should be between 0 and 30.");
                            return;
                        }
                        PowerOfTwo.PrintPowersOfTwo(N);
                        break;
                    case 4:
                        Console.WriteLine("Please Enter Value:");
                        int input = Convert.ToInt32(Console.ReadLine());
                        Console.Write(Harmonic.nthHarmonic(input));
                        break;
                    case 5:
                        Console.Write("Enter a number to find its prime factors: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        PrimeFactors.Factors(n);
                        break;
                    case 6:
                        Console.WriteLine("Enter dividend: ");
                        int dividend = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter divisor: ");
                        int divisor = Convert.ToInt32(Console.ReadLine());
                        QuotientAndRemainder quotientAndRemainder = new QuotientAndRemainder();
                        quotientAndRemainder.Calculation(dividend,divisor);
                        break;
                    case 7:
                        Console.WriteLine("Enter First number");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Second number");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Swaping.Swap(a,b);
                        break;
                    case 8:
                        Console.WriteLine("Please Enter a Number");
                        EvenOrOdd evenOrOdd = new EvenOrOdd();
                        evenOrOdd.CheckEvenOdd();
                        break;
                    case 9:
                        Console.WriteLine("Please Enter a Character");
                        char ch = Convert.ToChar(Console.ReadLine());
                        Alphabet alphabet = new Alphabet();
                        alphabet.Vowel(ch);
                        break;
                    case 10:
                        Console.WriteLine("Enter three numbers:");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        int num3 = Convert.ToInt32(Console.ReadLine());

                        int largest = LargestAmongThree.GetLargest(num1, num2, num3);
                        Console.WriteLine("The largest number is {0}", largest);
                        break;
                    case 0:
                        Console.WriteLine("Exiting the program...");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please choose a valid option.");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
