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
            // https://youtu.be/GlGpSQsS8uc?si=ZX5fYzZlXMvn8xYx&t=14620


            //Dictionary of type int (key) and string (value)
            Dictionary<int, string> names = new Dictionary<int, string>();

            names.Add(1, "Steve");
            names.Add(2, "Me");
            names.Add(3, "You");
            names.Add(4, "He");
            names.Add(5, "She");

            Dictionary<int, string> names2 = new Dictionary<int, string>
            {
                {1,"Steve"},
                {2,"Me"},
                {3,"You"},
                {4,"He"},
                {5,"She"}
            };

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names.ElementAt(i));
            }

            Console.WriteLine($"Get specific element at position {4}: {names.ElementAt(4)}");

            KeyValuePair<int, string> pair = names.ElementAt(2);
            Console.WriteLine($"Pair key: {pair.Key}");
            Console.WriteLine($"Pair value: {pair.Value}");
            Console.WriteLine($"Pair: {pair.Key} : {pair.Value}");

            foreach (KeyValuePair<int, string> item in names)
            {
                Console.WriteLine(pair);
            }

            if(names.TryGetValue(2, out string namey))
            {
                Console.WriteLine(namey);
            }

            Dictionary<string, string> teachers = new Dictionary<string, string>
            {
                { "Spanish", "Steve" },
                { "Software", "Pete" },
                { "D&T", "Stu" }
            };

            if (teachers.TryGetValue("software", out string teacher))
            {
                Console.WriteLine(teacher);
            }
            if (teachers.TryGetValue("Software", out string teacher2))
            {
                Console.WriteLine(teacher2);
            }

            if(teachers.ContainsKey("Spanish"))
            {
                Console.WriteLine("Spanish teacher found");
            }

            Console.ReadLine();
        }
    }
}
