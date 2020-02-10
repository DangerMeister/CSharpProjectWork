using System;

namespace EulerProblem6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            int sumOfSquares = SumOfSquares(n);
            int squareOfSums = SquareOfSums(n);
            int difference = squareOfSums - sumOfSquares;
            Console.WriteLine(difference);
        }
        static int SumOfSquares(int input)
        {
            int output = 0;
            for (int i = 1; i <= input; i++)
            {
                int power = (int)Math.Pow(i, 2);
                output += power;
            }
            //output = (((2 * input) + 1) * (input + 1) * input) / 6;
            return output;
        }
        static int SquareOfSums(int input)
        {
            int output = 0;
            int sum = 0;
            for (int i = 1; i <= input; i++)
            {
                sum += i;
            }
            //sum = (input * (input + 1)) / 2;
            output = (int)Math.Pow(sum, 2);
            return output;
        }
    }
}
