//Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN
using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter N ");
        decimal n = int.Parse(Console.ReadLine());
        Console.Write("Enter X ");
        int xConst = int.Parse(Console.ReadLine());
        decimal sum = 1.0m;
        decimal x = xConst;
        Console.WriteLine(1);
        for (int i = 1; i <=n; i++)
        {
            int factorielN = 1;
            for (int k = 1; k <= i; k++)
            {
                factorielN *= k;
            }
            sum += factorielN / x;
            Console.WriteLine("{0}!/{1}^{0} = {2} / {3} = {4}", i, xConst, factorielN, x, sum-1);
            x = x*xConst;
        }
        Console.WriteLine("Sum is "+sum);
    }
}

