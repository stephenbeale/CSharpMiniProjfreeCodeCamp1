using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;
using System.Threading;
using System.Xml;

namespace CSharpMiniProjfreeCodeCamp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://youtu.be/GlGpSQsS8uc?si=P0siFmWiXEtHdPDM&t=21652

            bool looping = false;

            while (!looping)
            {
                try
                {
                    Console.WriteLine("Enter a number: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Your number: {num}");

                    looping = true;
                }
                //catch (FormatException)
                //{
                //    Console.WriteLine("Please only enter numbers");

                //}
                //catch (OverflowException)
                //{
                //    Console.WriteLine("Please enter a number less than 2 billion");

                //}
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                    Console.WriteLine("Exception!");
                }
            }

            Console.ReadLine();
        }
    }
}
