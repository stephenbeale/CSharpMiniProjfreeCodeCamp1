using System;

namespace CSharpMiniProjfreeCodeCamp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://youtu.be/GlGpSQsS8uc?si=2N-U96UooX97cxsT&t=7184

            bool numInput = false;
            Console.WriteLine("Enter a number to multiply by:");
            var input = Console.ReadLine();

            try
            {
                if (int.TryParse(input, out int result))
                {
                    Console.WriteLine("Times table is:");

                    for (int i = 1; i <= 12; i++)
                    {
                        Console.WriteLine($"{i}: {i} * {result} = {i * result}");
                    }
                }
            }

            //Only use try-catch for specific exceptions
            catch 
            {
                throw new Exception();

            }          

            Console.ReadLine();
        }
    }
}
