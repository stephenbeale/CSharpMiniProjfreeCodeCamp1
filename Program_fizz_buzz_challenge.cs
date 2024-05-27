using System;

namespace CSharpMiniProjfreeCodeCamp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://youtu.be/GlGpSQsS8uc?si=QaMgoRyJzC5FooBY&t=7388
            
                for (int i = 1; i <= 15; i++)
                {
                    if((i % 3 == 0 && i % 5 == 0)) 
                    {
                    Console.WriteLine("Fizz Buzz");                                        
                    }
                    if(i % 5 == 0)
                    {
                    Console.WriteLine("Buzz");
                    }
                    else if (i % 3 == 0)
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
