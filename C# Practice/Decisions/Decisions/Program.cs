using System;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pruthvin's Give Away");
            Console.Write("Choose a door: 1,2, or 3 :");
            string userValue =Console.ReadLine();

            if (userValue == "1")
            {
                string message = "You won Jeep";
                Console.WriteLine(message);
            }
            else if (userValue == "2")
            { 
                string message = "You won Car";
                Console.WriteLine(message);
            }

            else if (userValue == "3")
            {
                string message = "You won Boat";
                Console.WriteLine(message);
            }

            else
            {
                string message = "Sorry!!!";
                Console.WriteLine(message);
            }
            Console.ReadLine();
        }
    }
}
