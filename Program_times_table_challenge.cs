using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
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
            // https://youtu.be/GlGpSQsS8uc?si=2N-U96UooX97cxsT&t=7184

            bool numInput = false;
            Console.WriteLine("Enter a number to multiply by:");
            var input = Console.ReadLine();

            try
            {
                if (int.TryParse(input, out int result))
                {
                    Console.WriteLine("Times table is:");

                    for (int i = 1; i <= 12; i++)
                    {
                        Console.WriteLine($"{i}: {i} * {result} = {i * result}");
                    }
                }
            }
            catch 
            {
                throw new Exception();

            }          

            Console.ReadLine();
        }
    }
}
