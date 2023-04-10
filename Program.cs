using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Takrorla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number : ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine(i + "foo bar");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + " foo");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + " bar");
                }
            }
            Console.ReadLine();
        }
    }
}
