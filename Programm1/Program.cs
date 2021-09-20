using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programm1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3.14, y = 17.25;

            double add, sub, mul, div;

            add = x + y;

            sub = x - y;

            mul = x * y;

            div = x / y;

            Console.Write("add = " + add + "\n\n" +
                           "sub = " + sub + "\n\n" +
                           "mul = " + mul + "\n\n" +
                           "div = " + div);

            Console.ReadLine();
        }
    }
}
