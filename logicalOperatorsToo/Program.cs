using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalOperatorsToo
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine(366);
            }
            else
            {
                Console.WriteLine(365);
            }
            Console.ReadKey();
        }
    }
}