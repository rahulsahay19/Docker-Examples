using System;

namespace hello_docker_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Getting started with docker!");
            }
            else
            {
                Console.WriteLine("Printing arguments!");
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine(args[i]);
                }
            }
        }
    }
}
