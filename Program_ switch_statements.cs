using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CSharpMiniProjfreeCodeCamp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://youtu.be/GlGpSQsS8uc?si=9wK6dyGZc7ZPgaKL&t=4126

            Console.Write("Enter a day of the week as a number (1 = Monday, 7 = Sunday):");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1: 
                    Console.WriteLine($"Day {day} is Monday");
                    break;
                case 2:
                    Console.WriteLine($"Day {day} is Tuesday");
                    break;
                case 3:
                    Console.WriteLine($"Day {day} is Wednesday");
                    break;
                case 4:
                    Console.WriteLine($"Day {day} is Thursday");
                    break;
                case 5:
                Console.WriteLine($"Day {day} is Wednesday");
                    break;
                case 6:
                    Console.WriteLine($"Day {day} is Wednesday");
                    break;
                case 7:
                    Console.WriteLine($"Day {day} is Wednesday");
                    break;
                default: 
                    Console.WriteLine("Not a day of the week!");
                    break;
            }

            Console.ReadLine();
        }
    }
}
