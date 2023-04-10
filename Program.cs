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
            Console.Write("Enter Number  : ");
            int input = int.Parse(Console.ReadLine());

            Console.Write("Sum : " + Sum(input));

            Console.ReadLine();

        }
        public static int Sum(int a)
        {
            int sum = 0;

            while (a > 0)
            {
                sum += a % 10;
                a /= 10;
            }

            return sum;
        }
    }
}
