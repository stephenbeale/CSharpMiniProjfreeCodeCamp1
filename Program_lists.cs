using System;
using System.Collections.Generic;
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
            // https://youtu.be/GlGpSQsS8uc?si=iTlKfQQvk02s5fkX&t=14128

            List<string> list = new List<string>();
            List<int> list2 = new List<int>()
            {
                1,23,264,5,465,8789
            };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter a number:");                
                int num = Convert.ToInt32(Console.ReadLine());
                list2.Add(num);
            }

            foreach (int num in list2)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }
    }
}
