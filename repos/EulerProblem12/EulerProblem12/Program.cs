using System;

namespace EulerProblem12
{
    class Program
    {
        static void Main(string[] args)
        {
            int divisorsExpected = 500;
            int triangleNumber = 0;
            int i = 1;

            while (CountDivisors(triangleNumber) < divisorsExpected)
            {
                triangleNumber += i;
                i++;
            }

            Console.WriteLine(triangleNumber);
        }
        static int CountDivisors(int triangleNumber)
        {
            int countOfDivisors = 0;
            int squareRoot = (int)Math.Sqrt(triangleNumber);

            for (int i = 1; i <= squareRoot; i++)
            {
                if (triangleNumber % i == 0)
                {
                    countOfDivisors += 2;
                }
            }
            if (squareRoot*squareRoot == triangleNumber)
            {
                countOfDivisors--;
            }
            return countOfDivisors;
        }
    }
}
