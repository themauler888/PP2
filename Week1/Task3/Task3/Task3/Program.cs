using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());// Insert string and convert to int
            int[] a = new int[n]; // Create massive
            for (int i = 0; i < n; i++) //cycle to fill massive             
            {
                int b = int.Parse(Console.ReadLine());
                a[i] = b;
            }
            for (int i = 0; i < n; i++) // cycle to fill elements of massive        
            {
                Console.Write(a[i] + " " + a[i] + " ");//element of massive with repetition
            }
        }
    }
}
