using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;

namespace CSharpMiniProjfreeCodeCamp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://youtu.be/GlGpSQsS8uc?si=I0MIHaL5uByhyo0W&t=8211

            var string1 = "first";
            var string2 = "second";
            var string3 = "third";

            string[] names = { string1, string2, string3 };
            string[] names2 = { "me", "you", "him" };

            names.ToList().ForEach(x => Console.WriteLine($"Names now: {x}"));
            Console.WriteLine(names2.Length);
            names2.CopyTo(names, 0);
            //Using Linq
            names.ToList().ForEach(x => Console.WriteLine($"Names now: {x}"));

            Console.ReadLine();            
        }
    }
}
