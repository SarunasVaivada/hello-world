using System;
using System.Linq;

namespace HelloWorld
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            var input = @"SAS 9.3 - CI Studio, SDM Studio and Enterprise Guide is working fine and Metadata refresh job completed successfully overnight.";
            var counts = input.GroupBy(c => c).Select(g => new { Char = g.Key, Count = g.Count() });

            //counts.OrderByDescending(g => g.Count);

            foreach (var item in counts.OrderByDescending(g => g.Count))
            {
                Console.WriteLine($"Character: {item.Char} is repeated: {item.Count} times");
            }



            //if (args.Length < 1)
            //{
            //    Console.WriteLine("Application requires at least 1 argument!");
            //    return;
            //}

            //var module = new HelloModule();

            //Console.WriteLine(module.SayHello(args[0]));
            Console.ReadLine();
        }
    }
}
