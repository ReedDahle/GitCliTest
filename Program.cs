using System;

namespace GitCliTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from git!");       // this is an edit
            Console.WriteLine("Say something nice: ");  // it should show up in the second commit
            string input = Console.ReadLine();
            Console.WriteLine($"You said: {input}");

            /*
            this is the third commit:
            using add command to stage changes instead of vscode
            */

            /*
            this is the fourth commit:
            using vscode to push
            */
        }
    }
}
