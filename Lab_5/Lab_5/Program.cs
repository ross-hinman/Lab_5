using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string again = "t";
            Console.WriteLine("Welcome to the Factorial Calculator!\n");

            do
            {
                Console.WriteLine("Enter an integer that greater than 0 but less than 10:");
                int x = Convert.ToInt16(Console.ReadLine());
                int factor = 1;

                for (int i = 1; i <= x; ++i)
                {
                    factor = factor * i;
                }
                Console.WriteLine($"{x}! = {factor}\n");
                Console.WriteLine("Would you like to continue? (y/n)");

                string repeat = Console.ReadLine();
                repeat = repeat.ToLower();

                if (repeat == "y")
                {
                    again = "t";
                }
                else if (repeat == "n")
                {
                    Console.WriteLine("Thank you for calculating!");
                    again = "f";
                }
            } while (again == "t");
        }
    }
}
