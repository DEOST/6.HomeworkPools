//Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm (find it in decimalernet)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.GreatestComonDiviser
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter N ");
            decimal n = decimal.Parse(Console.ReadLine());
            Console.Write("Enter K ");
            decimal k = decimal.Parse(Console.ReadLine());
            decimal gcd = 1;
            if (n > k)
            {
                if (n % k == 0)
                {
                }
                else
                {
                    while (n % k != 0)
                    {
                        k = k % (n % k);
                    }
                 }
                gcd = k;
            }

            else
            {
                if (k % n == 0)
                {
                }
                else
                {
                    while (k % n != 0)
                    {
                        n = n % (k % n);
                    }
                }
                gcd = n;
            }
            Console.WriteLine("GreatestComonDiviser is {0} ", gcd);
        }
    }
}

