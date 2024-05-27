//using System;

//namespace CSharpMiniProjfreeCodeCamp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            // https://youtu.be/GlGpSQsS8uc?si=2N-U96UooX97cxsT&t=7184

//            bool numInput = false;
//            Console.WriteLine("Enter a number to multiply by:");
//            var input = Console.ReadLine();
            
//                if (int.TryParse(input, out int result))
//                {
//                    Console.WriteLine("Times table is:");

//                    for (int i = 1; i <= 12; i++)
//                    {
//                        //My way
//                        Console.WriteLine($"My way: {i}: {i} * {result} = {i * result}");

//                    //Course way
//                    //First arg corresponds to params passed as arguments
//                    Console.WriteLine("Course way: {0} x {1} = {2}", i, input, i * result);
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Invalid input");
//                }
//            Console.ReadLine();
//        }
//    }
//}
