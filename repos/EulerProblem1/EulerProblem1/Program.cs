using System;

namespace EulerProblem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiples = 0;

            for (int i = 0; i < 1000; i++)
            {
                bool divisibleByThree = false;
                bool divisibleByFive = false;

                divisibleByThree = DivideByThree(i);
                divisibleByFive = DivideByFive(i);

                if (divisibleByThree || divisibleByFive)
                {
                    multiples = multiples + i;
                }
            }
            Console.WriteLine(multiples);
        }
        static bool DivideByThree(int i)
        {
            if (i % 3 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool DivideByFive(int i)
        {
            if (i % 5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

