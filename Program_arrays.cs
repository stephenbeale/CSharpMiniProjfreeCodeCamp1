using System;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Runtime.Remoting.Services;
using System.Threading;
using System.Xml;

namespace CSharpMiniProjfreeCodeCamp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://youtu.be/GlGpSQsS8uc?si=pzIyVCo_6xrnq2Su&t=12849

            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var test = "";
            test.Replace(" ", "");

            foreach (var item in numbers)
            {
                Console.WriteLine($"Array: {item}");
            }

            
            Array.Sort(numbers);
            //Does nothing
            //Console.WriteLine($"Array: {numbers}");
            Array.Reverse(numbers);

            foreach (var item in numbers)
            {
                Console.WriteLine($"Array: {item}");
            }

            Console.ReadLine();
        }
    }
}
