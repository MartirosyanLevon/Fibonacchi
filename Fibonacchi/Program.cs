using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacchi
{
    class Program
    {
        static void Main(string[] args)
        {
            double prevFib = 1, curFib = 1;

            for (int i = 0; i <= prevFib; i++)
            {
                double newFib = prevFib + curFib;
                prevFib = curFib;
                curFib = newFib;
                Console.WriteLine(prevFib);

                Console.ReadKey();

            }
        }
    }
}