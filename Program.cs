using System;
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

            //Continue from: https://youtu.be/YrtFtdTTfv0?si=LnE6dYRk-k0I5WtX&t=1000

            //Multiple variable declarations
            //int x, y, z;

            int x = 10, y = 20, z = 30;

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
            Console.WriteLine($"Double max value: {double.MaxValue}");
            Console.WriteLine($"Double min value: { double.MinValue}");

            //F at end to register number with decimal as a float, not a double
            float precision = 5.000001F;

            Console.WriteLine(precision);
            Console.WriteLine($"Float max: {float.MaxValue}");
            Console.WriteLine($"Float min: {float.MinValue}");

            //M at end to override double
            decimal money = 1.3457955M;
            Console.WriteLine(money);
            Console.WriteLine($"Decimal max: {decimal.MaxValue}");
            Console.WriteLine($"Decimal min: {decimal.MinValue}");



            Console.ReadLine();

        }
    }
}
