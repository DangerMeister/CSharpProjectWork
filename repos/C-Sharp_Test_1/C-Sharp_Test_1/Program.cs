using System;

namespace C_Sharp_Test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string textInput;
            Console.WriteLine("Please enter some text:\n");
            textInput = Console.ReadLine();
            Console.WriteLine("You entered: {0}", textInput);
        }
    }
}