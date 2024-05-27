using System;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Services;
using System.Threading;

namespace CSharpMiniProjfreeCodeCamp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://youtu.be/GlGpSQsS8uc?si=5DKkVmujSlfY6pfA&t=9150

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            
            if(name != string.Empty)
            {
                Console.WriteLine($"Your name is {name}");
            }
            else
            {
                Console.WriteLine("Name is empty.");
            }
            Console.ReadLine();            
        }
    }
}
