using System;

namespace Insem_1_Q5_202012093
{
    class Program
    {
        static void Main(string[] args)
        {
            static void AnArray()
            {
                object[] Hello = new object[4];
                Hello[0] = 07;
                Hello[1] = true;
                Hello[2] = new DateTime(2019, 01, 01);
                Hello[3] = "Sample String";

                foreach (object x in Hello)
                {
                    Console.WriteLine(x);
                }
            }

            AnArray();
        }
    }
}
