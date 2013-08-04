using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Prints1ToN
{
    class Print1ToN
    {
        static void Main()
        {
            Console.WriteLine("Enter N ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.Write(i + ", ");
            }
        }
    }
}
