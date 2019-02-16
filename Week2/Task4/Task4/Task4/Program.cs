using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter(@"C:\Users\THE_MAULER\Desktop\PP2\Week2\Task4\1.txt");
            writer.Write("ALIQ");
            writer.Close();
            File.Copy(@"C:\Users\THE_MAULER\Desktop\PP2\Week2\Task4\1.txt", @"C:\Users\THE_MAULER\Desktop\PP2\Week2\Task4\2.txt");
            File.Delete(@"C:\Users\THE_MAULER\Desktop\PP2\Week2\Task4\1.txt");
        }
    }
}
