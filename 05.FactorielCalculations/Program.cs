//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter N (1<N<K) ");
        long n = long.Parse(Console.ReadLine());
        Console.Write("Enter K (1<N<K) ");
        long k = long.Parse(Console.ReadLine());
        long factorielN = 1;
        long factorielK = 1; //N!*K! / (K-N)! = N!( K*(K-1)*...(K-N))
        for (long i = 1; i <= n; i++)
        {
            factorielN *= i;
            Console.Write("{0} * ", i);
        }
        Console.Write("( ");
        for (long i = k; i >= k-n+1; i--)
        {
            factorielK *= i;
            Console.Write("{0} ", i);
            if (i != k-n+1)
            {
                Console.Write("* ");
            }       
        }
        Console.WriteLine(" ) = "+(factorielN*factorielK));
    }
}

