using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming
{
    public class CoinFlip
    {
        private int headsCount;
        private int tailsCount;
        private Random random;

        public CoinFlip()
        {
            random = new Random();
            headsCount = 0;
            tailsCount = 0;
        }

        public void PerformFlips(int numberOfFlips)
        {
            for (int i = 0; i < numberOfFlips; i++)
            {
                double randomValue = random.NextDouble();

                if (randomValue < 0.5)
                    tailsCount++;
                else
                    headsCount++;
            }
        }

        public void DisplayResults()
        {
            double headsPercentage = (double)headsCount / (headsCount + tailsCount) * 100;
            double tailsPercentage = (double)tailsCount / (headsCount + tailsCount) * 100;

            Console.WriteLine("Heads: {0} ({1:F2}%)", headsCount, headsPercentage);
            Console.WriteLine("Tails: {0} ({1:F2}%)", tailsCount, tailsPercentage);
        }
    }
}
