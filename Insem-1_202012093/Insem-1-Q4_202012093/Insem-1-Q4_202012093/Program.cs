using System;

namespace Insem_1_Q4_202012093
{
    class Program
    {
        static void Main(string [] args)
        {
            KnowVar x = new KnowVar();
            x.MyMethod(20);
        }
    }
    class KnowVar
    {
        int _m = 10;
        public void MyMethod(int i, int j = 10)
        {
            var k = i + j;
            var sum = "The sum ";
            var n = 0;
            var mul = " ";
            n = i * j;
            mul = "The multiplication ";
            var ob = new Program();
            KnowVar ob2 = null;
            Console.Write(sum);
            Console.WriteLine(k);
            Console.Write(mul);
            Console.WriteLine(n);

        }
    }
}
