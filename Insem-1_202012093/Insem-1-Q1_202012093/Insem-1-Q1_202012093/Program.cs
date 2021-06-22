using System;

namespace Insem_1_202012093
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            int sum = Calculator.AddNums(a, b);
            /* fill in the blank below*/
            string output = "The sum of " + a + " and " + b + " is " + sum;
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
    /* define the class here*/
    class Calculator
    {
        public static int AddNums(int a, int b)
        {
            return a + b;
        }

    }
}