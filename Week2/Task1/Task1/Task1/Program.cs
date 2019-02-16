using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        static bool Pol(string a) // function which will check for polindrome 
        {
            for (int i = 0; i < a.Length / 2; i++)
            {
                if (a[i] != a[a.Length - 1 - i]) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            StreamReader b = new StreamReader(@"C:\Users\THE_MAULER\Desktop\PP2\Week2\Task1\Task1\1.txt"); // object which will be read from the text 
            string s = b.ReadToEnd(); // read and save it to b 
            if (Pol(s) == true)
                Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}
