using System;

namespace Insem_1_Q2_202012093
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "hello world";
            s.Replace('o', 'i');
            s.Replace("r", string.Empty);
            Console.WriteLine(s);
            Console.ReadLine();
         }
    }
}

/* OutPut : hello world
 *Because all the changes wont affect the main original string 
 **/