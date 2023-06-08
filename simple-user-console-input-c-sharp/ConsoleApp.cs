using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string username = Console.ReadLine();
            Console.WriteLine($"Hello {username}");
            Console.ReadLine();
        }
    }
}
