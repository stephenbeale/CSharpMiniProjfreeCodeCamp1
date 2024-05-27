//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Diagnostics;
//using System.Diagnostics.Eventing.Reader;
//using System.Globalization;
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
//            // https://youtu.be/GlGpSQsS8uc?si=QMidGYoWBaMcy33O&t=5764

//            bool success = true;

//            while (success)
//            {
//                Console.Write("Enter a number: ");
//                string numInput = Console.ReadLine();

//                if(int.TryParse(numInput, out int num))
//                {
//                    success = false;
//                    Console.WriteLine(num);
//                }
//                else
//                {
//                    Console.WriteLine("Failed to convert!");
//                }
//            }
            
//            Console.ReadLine();
//        }
//    }
//}
