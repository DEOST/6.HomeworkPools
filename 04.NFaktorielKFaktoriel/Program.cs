//Write a program that calculates N!/K! for given N and K (1<K<N).
using System;
class Program
{
    static void Main()
    {
        checked
        {
            Console.Write("Enter N ");
            long N = long.Parse(Console.ReadLine());
            Console.Write("Enter K ");
            long K = long.Parse(Console.ReadLine());
            long factoriel = 1;
            //N!/K! = (K+1)*(K+2)*(K+3)....*N
            for (long i = N; i > K; i--)
            {
                factoriel *= i;
            }
            Console.WriteLine("N!/K! = " + factoriel);
        }
    }
}
