using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exampleElseIf
{
    class Program
    {
        static void Main(string[] args)
        {
            int whoCall = int.Parse(Console.ReadLine());
            if (whoCall == 1)
            {
                Console.WriteLine("Football!!");
            }
            else if (whoCall == 2)
            {
                Console.WriteLine("C#!!!");
            }
            else
            {
                Console.WriteLine("Show");
            }
            Console.ReadKey();
        }
    }
}