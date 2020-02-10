using System;

namespace EulerProblem7
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int i = 2;
            while (counter < 10001)
            {
                if (IsPrime(i))
                {
                    counter++;
                }
                i++;
            }
            i -= 1;
            Console.WriteLine(i);
        }
        static bool IsPrime(long primeTestNumber)
        {
            for (long i = 2; i <= primeTestNumber/2; i++)
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
