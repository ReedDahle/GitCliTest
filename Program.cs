using System;

namespace GitCliTest
{
    class Program
    {
        static void Main(string[] args)
        {
            for (long i=1; i<=1000000; i++)
            {
                long num = i;
                Console.Write($"{num}: ");
                while (num != 1)
                {
                    if (num % 2 == 0)
                    {
                        num = num / 2;
                    }
                    else
                    {
                        num = (3 * num) + 1;
                    }
                }
                Console.WriteLine("TRUE");
            }
        }
    }
}
