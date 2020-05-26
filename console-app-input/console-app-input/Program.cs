using System;

namespace console_app_input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Input");
            var name = Console.ReadLine();
            Console.WriteLine($"Input entered as: {name}");
        }
    }
}

