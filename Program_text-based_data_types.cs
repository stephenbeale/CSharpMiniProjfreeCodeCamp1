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

            //Continue from: https://youtu.be/YrtFtdTTfv0?si=usRziHVM6i2itCR4&t=1350
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

            string bigNumber = "-90000000";
            Console.WriteLine($"Big# as string: {bigNumber}");
            //L enforces long, rather than int32
            long big = Convert.ToInt64(bigNumber);
            //long bigNumber = 90000000L;
            Console.WriteLine($"Big# as converted long: {bigNumber}");


            string textNegative = "-55.2";
            Console.WriteLine($"Text negative double as string: {textNegative}");
            double negative = Convert.ToDouble(textNegative);
            Console.WriteLine($"Text negative as converted double: {negative}");

            Console.WriteLine($"negative {negative}");

            //F at end to register number with decimal as a float, not a double
            string floaty = "5.000001";
            Console.WriteLine(floaty);
            //Single because a float is defined as a single - it's a struct in the System.Single class
            float floatyMcFloatFace = Convert.ToSingle(floaty);
            Console.WriteLine(floaty);


            float precision = 5.000001F;

            Console.WriteLine(precision);

            //M at end to override double
            decimal money = 14.99M;
            Console.WriteLine(money);

            Console.ReadLine();

        }
    }
}
