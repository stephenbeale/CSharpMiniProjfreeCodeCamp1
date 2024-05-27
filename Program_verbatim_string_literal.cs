using System;
using System.Threading;

namespace CSharpMiniProjfreeCodeCamp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://youtu.be/GlGpSQsS8uc?si=Uh0VVAKusAsQHjFV&t=8162

            //\t \n \" \\ = \
            var speech = "He said \"something\"";
            var path = "C:\\Users\\CoffeeNCode\\Desktop\\C# Course\nNew line test";

            Console.WriteLine(path);
            Console.WriteLine(speech);

            //SO - 'It marks the string as a verbatim string literal - anything in the string that would normally be interpreted as an escape sequence is ignored.'

            var name = @"Hello ""someone""";
            Console.WriteLine();

            Console.ReadLine();
        

            
        }
    }
}
