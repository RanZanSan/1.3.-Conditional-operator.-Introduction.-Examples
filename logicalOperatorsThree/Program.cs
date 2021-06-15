using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalOperatorsThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            bool mod400 = year % 400 == 0;
            if (year % 4 == 0 && year % 100 != 0 || mod400)
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