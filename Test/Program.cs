using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "sw  ";
            if (s.Trim().EndsWith("  "))
                Console.Write("Yes");
            else
                Console.Write("No");
            Console.ReadKey();
        }
    }
}
