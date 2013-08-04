//Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, using System;
using System;
class Program
{
    static void Main()
    {
        checked
        {
            Console.Write("Enter N ");
            int n = int.Parse(Console.ReadLine());
            int fiboone = 0;
            int fibotwo = 1;
            int sum = 1;
            for (int i = 1; i < n; i++)
            {
                System.Console.Write("{0}, ", fiboone, fibotwo, sum);
                sum = fibotwo + fiboone;
                fiboone = fibotwo;
                fibotwo = sum;
          
            }
            Console.WriteLine("{0} = {1}", fiboone, sum);
        }
    }
}

