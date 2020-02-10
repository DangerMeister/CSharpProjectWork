using System;

namespace EulerProblem9
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 1000; a++)
            {
                for (int b = a + 1; b <= 1000; b++)
                {
                    for (int c = b + 1; c <= 1000; c++)
                    {
                        if (a + b + c == 1000)
                        {
                            if (Math.Pow(a,2) + Math.Pow(b,2) == Math.Pow(c,2))
                            {
                                Console.WriteLine("{0}", a * b * c);
                            }
                        }
                    }
                }
            }


        }
    }
}
