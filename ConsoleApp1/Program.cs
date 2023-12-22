using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double P = 1;
            int d;
            int f;
            for (d= 1;d<=4;d++)
            {
                double S = 0;
                for (f = 1; f <= 3; f++)
                {
                    S= Log(d + f / 2);
                }
                P = P * S;
            }
            Console.WriteLine($"P={P}");
        }
    }
}
