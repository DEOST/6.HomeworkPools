using System;
class Program
{
    static void Main()
    {        
        int bufer = 64;
        int fiboone = int.Parse(Console.ReadLine()) - bufer;
        int fibotwo = int.Parse(Console.ReadLine()) - bufer;
        int n = int.Parse(Console.ReadLine());
        Console.Write((char)(fiboone + bufer));
        if (n>1)
        {
            fibothree = fibotwo + fiboone;
            if (fibothree > 26)
            {
                fibothree = fibothree % 26;
            }
        }
        string result = ((char)(fibotwo +bufer)).ToString()+((char)(fibothree+bufer)).ToString();
        Console.WriteLine(result);
        fiboone = fibotwo;
        for (int i = 3; i <= n; i++)
        {
            Console.WriteLine((char)(fibotwo + bufer)).ToString();
            Console.Write(new string(' ', i - 2));
            Console.WriteLine((char)(fibothree + bufer)).ToString();

            fiboone = fibothree;
            fibotwo += fiboone;
            fibothree = fibotwo + fiboone;
            
            
        }
    }
}

