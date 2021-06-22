using System;

namespace Insem_1_Q6_20201093
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Point a = new Point(50, 100);
            Console.WriteLine(a.X);
            Console.WriteLine(a.Y);
            Tuple<int, int> x = a.Deconstruct(50, 100);
            Console.WriteLine(x.Item1);
            Console.WriteLine(x.Item2);

        }
    }

    class Point
    {
        int x, y;
        public  int X { get { return x; } }
        public int Y { get { return y; }  }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Tuple<int,int> Deconstruct(int x,int y)
        {
            Tuple<int, int> a = new Tuple<int, int>(x, y);
            return a;
        }
    }
}
