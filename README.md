# C# Code Snippets

Challenge: Calculcate how often a number can be divided by another number without using Division and Modulo.

```
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int result = howOftenIsNumDividable(438, 19);
            Console.WriteLine($"438 can be divided by 19 {result} times.");

            Console.ReadLine();
        }

        static int howOftenIsNumDividable(int firstNum, int secondNum)            
        {
            int counter = 0;
            while (firstNum >= 1)
            {
                firstNum -= secondNum;
                if (firstNum >= 1)
                {
                    counter++;
                }
            }

            return counter;
        }

    }
}

```
