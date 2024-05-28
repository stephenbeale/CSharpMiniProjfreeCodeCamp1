using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Reflection;
using System.Runtime.Remoting.Services;
using System.Threading;
using System.Xml;

namespace CSharpMiniProjfreeCodeCamp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://youtu.be/GlGpSQsS8uc?si=zSPosrptEZipT6M2&t=15371

            List<int> odds = new List<int>();
            List<int> evens = new List<int>();

            for (int i = 0; i < 20; i++) 
            {
                if (i % 2 != 0)
                {
                    odds.Add(i);
                }
                else 
                { 
                    evens.Add(i);
                }
            }

            Console.WriteLine($"Odds list:");
            foreach (int i in odds)
            {
                Console.WriteLine($"{i}");
            }
            
            Console.WriteLine($"Evens list: {evens}");
            foreach (int i in evens)
            {
                Console.WriteLine($"{i}");
            }


            //Array insert task - https://youtu.be/GlGpSQsS8uc?si=aDLLEj33HNPkQJxy&t=15789

            Dictionary<int, int> numLength = new Dictionary<int, int>()
            {
                {1, 20 },
                {2, 30},
                {3, 60}
            };

            HelloWorldy();


            //Can call functions directly 
            Console.WriteLine($"{HelloWorld2()}");

            //Console.WriteLine($"{helloWorldy()}");
            Console.WriteLine($"Multiplier {Multiplier(4)}");
            Console.WriteLine($"{Add(3)}");
            Console.ReadLine();
        }

        static void HelloWorldy()
        {
            Console.WriteLine("Hello World!");
        }

        static string HelloWorld2()
        {
            return "Hello World!";
        }

        static int Multiplier(int num)
        {
            return num * num;
        }

        static int Add(int num)
        {
            return num + num;
        }

        static int Divider(int numerator, int denominator) => numerator / denominator;
    }
}
