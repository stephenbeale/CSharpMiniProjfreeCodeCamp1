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

            //Continue from: https://youtu.be/YrtFtdTTfv0?si=d-oKGjndWmYv_p3g&t=1234
            string name = "Aba";
            //Char with single quotation
            char letter = 'a';

            Console.WriteLine($"Your name is {name}");
            Console.WriteLine($"The letter is {letter}");

            string textAge = "-23";
            Console.WriteLine($"Text age as string: {textAge}");
            //Converts back to int
            int age = Convert.ToInt32(textAge);
            Console.WriteLine($"Text age as converted int: {textAge}");
            Console.WriteLine($"age: {age}");

            string bigNumber = "90000000L";
            //L enforces long, rather than int32
            long bigNumber = 90000000L;
            Console.WriteLine($"bigNumber {bigNumber}");

            long bigNumberNegative = -90000000L;
            Console.WriteLine($"bigNumberNegative {bigNumberNegative}");

            //D at end enforces double, if unsure
            double negative = -55.2D;

            Console.WriteLine($"negative {negative}");

            //F at end to register number with decimal as a float, not a double
            float precision = 5.000001F;

            Console.WriteLine(precision);

            //M at end to override double
            decimal money = 14.99M;
            Console.WriteLine(money);

            Console.ReadLine();

        }
    }
}
