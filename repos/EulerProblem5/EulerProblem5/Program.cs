using System;

namespace EulerProblem5
{
    class Program
    {
        static void Main(string[] args)
        {
            int divisor = 1;
            while (!CheckDivisibility(divisor))
            {
                divisor++;
            }
            Console.WriteLine(divisor);
        }
        static bool CheckDivisibility(int input)
        {
            for (int i = 20; i > 0; i--)
            {
                if (input % i != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}