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
            // https://youtu.be/GlGpSQsS8uc?si=xlfFYVMnWz8SsNLH&t=3093

            Console.Write("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine($"Inputted name: {name}");

            Console.Write("Enter your age:");
            string age = Console.ReadLine();
            Console.WriteLine($"Your age is {age}");

            Console.ReadLine();
        }
    }
}
