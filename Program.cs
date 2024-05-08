﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMiniProjfreeCodeCamp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 23;
            Console.WriteLine($"age: {age}");

            Console.WriteLine($"int.MaxValue {int.MaxValue}");
            Console.WriteLine($"int.MinValue {int.MinValue}");

            //L enforces long, rather than int32
            long bigNumber = 90000000L;

            Console.WriteLine($"long.MinValue {long.MinValue}");
            Console.WriteLine($"long.MaxValue {long.MaxValue}");
            Console.WriteLine($"bigNumber {bigNumber}");

            long bigNumberNegative = -90000000L;
            Console.WriteLine($"bigNumberNegative {bigNumberNegative}");

            //D at end enforces double, if unsure
            double negative = -55.2D;

            Console.WriteLine($"negative {negative}");

            Console.ReadLine();
        }
    }
}
