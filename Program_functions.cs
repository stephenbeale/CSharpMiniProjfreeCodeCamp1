//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Net.Http;
//using System.Reflection;
//using System.Runtime.InteropServices;
//using System.Runtime.Remoting.Services;
//using System.Threading;
//using System.Xml;

//namespace CSharpMiniProjfreeCodeCamp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            // https://youtu.be/GlGpSQsS8uc?si=MbhQecTF7SMUpdSF&t=19092

//            //Can call functions directly 
//            Console.WriteLine($"{HelloWorld2()}");

//            //Console.WriteLine($"{helloWorldy()}");
//            Console.WriteLine($"Multiplier {Multiplier(4)}");
//            Console.WriteLine($"{Add(3)}");

//            Console.WriteLine($"Lambda anonymous: {addLambdaAnon(2, 3)}"); // Output: 5

//            Console.WriteLine($"Anonymous function {stringAnonFunc("Steve")}");

//            var name = "Steve";
//            var age = 40;
//            var address = "1 Road Street";

//            PrintDetails( name, age, address );

//            //Specify and can change the order
//            PrintDetails(agey: age, 
//                addressy : address, 
//                namey : name);

//            Console.WriteLine();

//            int num = 10;

//            Assign(ref num);
            
//            Console.ReadLine();
//        }


//        //Reference parameters - pass parameters by reference, not value - ref keyword. A bit like a pointer
//        static void Assign(ref int num)
//        {
//            num = 20;
//        }

//        static void PrintDetails(string namey, int agey, string addressy)
//        {
//            Console.WriteLine($"Name: {namey}");
//            Console.WriteLine($"Age: {agey}");
//            Console.WriteLine($"Address: {addressy}");
//        }

//        static void HelloWorldy()
//        {
//            Console.WriteLine("Hello World!");
//        }

//        static string HelloWorld2()
//        {
//            return "Hello World!";
//        }

//        static int Multiplier(int num)
//        {
//            return num * num;
//        }

//        static int Add(int num)
//        {
//            return num + num;
//        }

//        //Optional params with that keyword
//        //Default a better option for optional
//        static int Add(int num, int num2 = default)
//        {
//            return num + num;
//        }

//        //Inline function initialisation
//        static int Divider(int numerator, int denominator) => numerator / denominator;

//        //Single-line property getter
//        public int MyProperty { get; } = 42;
//        public int DoubleProperty => MyProperty * 2;

//        //Single-line Lambda function - anonymous or lambda function
//        // <in1, in2, out result> name = parameters => action on parameters
//        static Func<int, int, int> addLambdaAnon = (x, y) => x + y;

//        static Func<string, string> stringAnonFunc = (name) => name.Insert(0, "AnonymousFunctionCalled ");
//    }
//}
