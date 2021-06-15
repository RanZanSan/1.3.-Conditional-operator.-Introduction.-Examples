using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int eyes = int.Parse(Console.ReadLine());
            int legs = int.Parse(Console.ReadLine());
            if (eyes == 8 && legs == 8)
            {
                Console.WriteLine("AAAAA!!!");
            }
            Console.ReadKey();
        }
    }
}