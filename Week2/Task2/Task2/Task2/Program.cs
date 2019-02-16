using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        static bool Prime(int n) // function which will check prime number 
        {
            if (n == 1 || n == 0) return false;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"C:\Users\THE_MAULER\Desktop\PP2\Week2\Task2\1.txt"); // object which will read the text 
            StreamWriter writer = new StreamWriter(@"C:\Users\THE_MAULER\Desktop\PP2\Week2\Task2\2.txt"); // object which will write to the file 
            string n = reader.ReadLine(); // reads to string 
            string[] a = n.Split(' '); // crating an array and split string n
            foreach (string s in a)
            {
                if (Prime(int.Parse(s)))
                    writer.Write(s + " ");
            }
            reader.Close();
            writer.Close();
        }
    }
}
