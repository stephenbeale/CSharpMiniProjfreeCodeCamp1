using System;
using System.Collections.Generic;
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
            // https://youtu.be/GlGpSQsS8uc?si=2ONCD3fMhkZXGi2M&t=3252

            Console.Write("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine($"Inputted name: {name}");

            Console.Write("Enter your age:");
            int agey = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Your age is {agey}");

            Console.ReadLine();
        }
    }
}
