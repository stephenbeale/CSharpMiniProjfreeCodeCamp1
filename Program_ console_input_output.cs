//using System;
//using System.Collections.Generic;
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
//            // https://youtu.be/GlGpSQsS8uc?si=7QJQU2NYWoqyxsM7&t=3862

//            //Console.Write("Enter your name:");
//            //string name = Console.ReadLine();
//            //Console.WriteLine($"Inputted name: {name}");

//            //Console.Write("Enter your age:");
//            ////Converts directly from input
//            //int agey = Convert.ToInt32(Console.ReadLine());

//            //Console.WriteLine($"Your age is {agey}");

//            //if (agey >= 18 && agey < 25)
//            //{
//            //    Console.WriteLine("You are allowed in because you are 18 or older");
//            //}
//            //else if(agey >= 25 && agey < 40)
//            //{
//            //    Console.WriteLine("25 or older");
//            //}
//            //else if (agey >= 40 && agey <= 75)
//            //{
//            //    Console.WriteLine("40 - 75 years");
//            //}
//            //if(agey < 0 || agey > 115)
//            //{
//            //    Console.WriteLine("Invalid age");
//            //}
//            //else
//            //{
//            //    Console.WriteLine("Valid age");
//            //};

//            Console.Write("Enter first number: ");
//            int numberA = Convert.ToInt32(Console.ReadLine());

//            Console.Write("Enter second number: ");
//            int numberB = Convert.ToInt32(Console.ReadLine());

//            int answer = numberA * numberB;
//            Console.Write($"What is {numberA} x {numberB}:");
//            string answerInput = Console.ReadLine();
//            int actualAsnwer = Convert.ToInt32(answerInput);

//            if(answer != actualAsnwer)
//            {
//                Console.WriteLine("Sorry, try again");
//            }
//            else
//            {
//                Console.WriteLine("Well done!");
//            }

//            Console.ReadLine();
//        }
//    }
//}
