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
           

            Random random = new Random();
            int[][] arr = new int[5][];          

            for (int i = 0; i < arr.Length;  i++)
            {
                arr[i] = new int[5];
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = random.Next(0, 10);
                    Console.Write(arr[i][j]+"  ");
                }
                Console.WriteLine();
            }
            int h = 0;
            int g = 0;           

            Console.WriteLine($"Diaganal : {h=(diaganal(arr))}");
            Console.WriteLine($"Oxirgi satr : {g=(ustun(arr))}");
            bool result = true;
            if (h < g ) result = false;
            Console.WriteLine($"natija : {result}"); 
            Console.ReadLine();
        }
        public static int diaganal(int[][] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {             
                        sum += arr[i][i];                
            }
            return sum;
        }
        public static int ustun(int[][] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {            
                        sum += arr[4][i];                
            }
            return sum;
        }
        
    }
}
