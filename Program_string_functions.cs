﻿//using System;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Net.Http;
//using System.Runtime.Remoting.Services;
//using System.Threading;
//using System.Xml;

//namespace CSharpMiniProjfreeCodeCamp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            // https://youtu.be/GlGpSQsS8uc?si=5DKkVmujSlfY6pfA&t=9150

//            Console.WriteLine("Enter your name: ");
//            string name = Console.ReadLine();

//            if (name != string.Empty)
//            {
//                Console.WriteLine($"Your name is {name}");
//            }
//            else
//            {
//                Console.WriteLine("Name is empty.");
//            }

//            if (name != "Steve")
//            {
//                Console.WriteLine("You are not Steve");
//            }

//            string message = "Hello";

//            char[] chars = new char[] { 'H', 'e', 'l', 'l', 'o' };
//            object newCompare = new string(chars);

//            if (message.Equals(newCompare))
//            {
//                Console.WriteLine("Same");
//            }
//            else
//            {
//                Console.WriteLine("Different");
//            };

//            message = "C# is awesome\n";

//            for (int i = 0; i < message.Length; i++)
//            {
//                Console.Write(message[i]);
//                Thread.Sleep(50);
//            }

//            bool contains = false;

//            for (int i = 0; i < message.Length; i++)
//            {
//                if (message[i] == '#')
//                {
//                    contains = true;
//                }
//                if (contains)
//                {
//                    Console.WriteLine("# found in your string");
//                    break;
//                }
//            }

//            //Belt and braces - if null, do not get exception for this.
//            if(!string.IsNullOrEmpty(name)) {
//                Console.WriteLine("String is not null or empty!");
//            }

//            Console.WriteLine(message.Contains("#"));

//            //Print string in reverse challenge

//            char[] messageChars = message.ToCharArray();
//            for (int i = messageChars.Length; i > 0; i--)
//            {
//                if (!string.IsNullOrEmpty(message))
//                {
//                    Console.Write(messageChars[i - 1]);
//                }
//            }

//            Console.ReadLine();
//        }
//    }
//}
