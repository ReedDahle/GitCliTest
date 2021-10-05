using System;

namespace GitCliTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from git!");
            Console.WriteLine("Say something nice: ");
            string input = Console.ReadLine();
            Console.WriteLine($"You said: {input}");
        }
    }
}
