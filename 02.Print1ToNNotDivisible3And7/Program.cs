using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Print1ToNNotDivisible3And7
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter N ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.Write("");
                }
                else
                {
                    Console.Write(i + ", ");
                }
            }
        }
    }
}
