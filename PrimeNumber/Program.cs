using System;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c=0;
            Console.WriteLine("Enter a Start number");
            a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a End number");
            b= Convert.ToInt32(Console.ReadLine());
            for (int i = a; i < b; i++)
            {
                for(int j = 1; j < b; j++)
                {
                    if(i%j==0)
                    {
                        c++;
                    }
                }
                if (c==2)
                {
                    
                    Console.WriteLine(i);
                }
                c = 0;
            }


        }
    }
}
