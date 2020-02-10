using System;

namespace EulerProblem3
{
    class Program
    {
        static void Main(string[] args)
        {
            const long target = 600851475143;

            for (long i = 1; i < target; i++)
            {
                if (target % i == 0)
                {
                    if (IsPrime(i))
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
        static bool IsPrime(long primeTestNumber)
        {
            for (long i = 2; i < primeTestNumber; i++)
            {
                if (primeTestNumber % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
