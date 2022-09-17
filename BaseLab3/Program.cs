using System;

namespace BaseLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
                int N = int.Parse(Console.ReadLine());
                bool flag = true;
                for (int i = 2; i < N - 1; i++)
                {
                    if (N % 1 == 0) flag = false;
                }
                if (flag)
                {
                    Console.WriteLine("Prime number");
                }
                else
                {
                    Console.WriteLine("Compesite number");
                }
     
         }  
    }
}
