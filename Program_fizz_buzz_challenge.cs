using System;
using System.Threading;

namespace CSharpMiniProjfreeCodeCamp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://youtu.be/GlGpSQsS8uc?si=QaMgoRyJzC5FooBY&t=7388
            
                for (int i = 1; i <= 15; i++)
                {
                bool threeDiv = i % 3 == 0;
                bool fiveDiv  = i % 5 == 0;
                if ((threeDiv && fiveDiv)) 
                    {
                    Console.WriteLine("Fizz Buzz");                                        
                    }
                    if(fiveDiv)
                    {
                    Console.WriteLine("Buzz");
                    }
                    else if (threeDiv)
                    {
                    Console.WriteLine("Fizz");
                    }
                    else 
                    {
                    Console.WriteLine(i);
                    };
                }
            Console.ReadLine();
        }
    }
}
