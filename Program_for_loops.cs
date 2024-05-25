//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Diagnostics.Eventing.Reader;
//using System.Linq;
//using System.Runtime.Remoting.Services;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Schema;

//namespace CSharpMiniProjfreeCodeCamp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            // https://youtu.be/GlGpSQsS8uc?si=59z9daoQH2qsHdS-&t=4462

//            Console.Write("How many times do you want to say hi?: ");
//            int loopCounter = Convert.ToInt32(Console.ReadLine());

//            if (loopCounter > 0)
//            {
//                for (int i = 0; i <= loopCounter; i++)
//                {
//                    Console.WriteLine($"i is {i}");
//                }

//                for (int i = 0; i <= loopCounter; i += 2)
//                {
//                    Console.WriteLine($"i is {i}");
//                }
//            }
//            else 
//            {
//                Console.WriteLine("Can't start loop with 0");
//            };

//            Console.ReadLine();
//        }
//    }
//}
