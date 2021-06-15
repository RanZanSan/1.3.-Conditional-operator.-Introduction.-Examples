using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nestedInstructions
{
    class Program
    {
        static void Main(string[] args)
        {
            int eyes = int.Parse(Console.ReadLine());
            int legs = int.Parse(Console.ReadLine());
            if (eyes >= 8)
            {
                if (legs == 8)
                {
                    Console.WriteLine("spider");
                }
                else
                {
                    Console.WriteLine("scallop");
                }
            }
            else
            {
                if (legs == 6)
                {
                    Console.WriteLine("bug");
                }
                else
                {
                    Console.WriteLine("cat");
                }
            }
            Console.ReadKey();
        }
    }
}