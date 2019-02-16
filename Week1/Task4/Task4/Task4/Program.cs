using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());// Insert string and convert to int
            int[,] a = new int[m, m]; // Create massive    
            for (int i = 0; i < m; i++) //cycle to fill massive             
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("[*]");
                }
                Console.WriteLine();

            }
        }
    }
}
