//Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter N ");
        int N = int.Parse(Console.ReadLine());
        int[] sequenceNum = new int[N];
        for (int i = 0; i < N; i++)
        {
            Console.Write("Type number {0} - ", i+1);
            sequenceNum[i] = int.Parse(Console.ReadLine());
        } 
        int max = sequenceNum.Max();
        int min = sequenceNum.Min();
        Console.WriteLine("\n\rmax is {0}, min is {1}", max, min);
    }
}

