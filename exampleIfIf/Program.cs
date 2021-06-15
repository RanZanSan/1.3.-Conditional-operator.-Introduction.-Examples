using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exampleIfIf
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine(a);
            }
            if (a < 0)
            {
                Console.WriteLine(-a);
            }
            Console.ReadKey();
        }
    }
}