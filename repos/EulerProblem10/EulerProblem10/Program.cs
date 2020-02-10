using System;

namespace EulerProblem10
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumOfPrimes = 0d;
            int maxCount = 2000000;

            for (int i = 1; i <= maxCount; i++)
            {
                if(CheckPrimality(i))
                {
                    sumOfPrimes += i;
                }
            }
            Console.WriteLine(sumOfPrimes);
        }
        static bool CheckPrimality(int inputNumber)
        {
            if(inputNumber == 1)
            {
                return false;
            }
            for (int i = 2; i <= inputNumber / 2; i++)
            {
                if (inputNumber % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
