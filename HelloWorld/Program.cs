using System;

namespace HelloWorld
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Application requires at least 1 argument!");
                return;
            }

            string name = args[0];

            Console.WriteLine(string.Format("Hello, {0}!", name));
            Console.ReadLine();
        }
    }
}
