using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CSharpMiniProjfreeCodeCamp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://youtu.be/GlGpSQsS8uc?si=vKBbpl_Qgo5WGdHk&t=2578

            var name = "Aba";
            Console.WriteLine($"My name is {name}");

            var number = "0123456789";
            Console.WriteLine($"My number is {number}");


            //Exercise - https://youtu.be/GlGpSQsS8uc?si=2LV6AJnwY7kWElap&t=2707

            /* Create & initalise two ints
                *Make a variable to work out the remainder
                *Output remainder to the screen
                *Change the first int variable to another number
                * and recalculate the remainder
                * output new remainder to the screen
                */

            int first = 29049804;
            int second = 43;
            int remainder = first % second;

            Console.WriteLine(remainder);

            first = 31;
            remainder= first % second;

            Console.WriteLine(remainder);

            Console.ReadLine();
        }
    }
}
