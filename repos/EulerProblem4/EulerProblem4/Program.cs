using System;

namespace EulerProblem4
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxIndex = 1000;
            int largestPalindrome = 0;

            for (int i = 100; i < maxIndex; i++)
            {
                for (int j = i; j < maxIndex; j++)
                {
                    int product = i * j;
                    if (CheckPalindrome(product))
                    {
                        if (product > largestPalindrome)
                        {
                            largestPalindrome = product;
                        }
                    }
                }
            }
            Console.WriteLine(largestPalindrome);
        }

        static bool CheckPalindrome(int inputCheck)
        {
            int keepInput = inputCheck;
            int remainderValue;
            int reverseNumber = 0;
            while (inputCheck!=0)
            {
                remainderValue = inputCheck % 10;
                reverseNumber = reverseNumber * 10 + remainderValue;
                inputCheck /= 10;
            }
            if (keepInput == reverseNumber)
            {
                return true;
            }
            return false;
        }
    }
}
