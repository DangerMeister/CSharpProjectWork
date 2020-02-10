using System;

namespace EulerProblem2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MaxNumber = 4000000;
            int fibonacciSum = 0;
            int lastFactorOne = 0;
            int lastFactorTwo = 1;
            int nextFactor = 0;

            while (nextFactor < MaxNumber)
            {
                nextFactor = lastFactorOne + lastFactorTwo;
                if (nextFactor % 2 ==0)
                {
                    fibonacciSum += nextFactor;
                }
                lastFactorOne = lastFactorTwo;
                lastFactorTwo = nextFactor;
            }
            Console.WriteLine(fibonacciSum);
        }
    }
}
