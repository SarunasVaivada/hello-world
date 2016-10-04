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

            var module = new HelloModule();

            Console.WriteLine(module.SayHello(args[0]));
            Console.ReadLine();
        }
    }
}
