using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Challenges
{
    class Program
    {
        static void Main()
        {
            for (int i = 1; i < 100; i++)
            {
                if ((i % 3 == 0) && (i % 5 != 0))
                {
                    Console.WriteLine("Fizz");
                }
                else if ((i % 3 != 0) && (i % 5 == 0))
                {
                    Console.WriteLine("Buzz");
                }
                else if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
