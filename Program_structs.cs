using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;
using System.Threading;
using System.Xml;

namespace CSharpMiniProjfreeCodeCamp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://youtu.be/GlGpSQsS8uc?si=i9d92AhIv49AiKzJ&t=24635      

            //Person person = new Person("Mr", 1, "Steve");
            Person personWithoutConstructor;

            personWithoutConstructor.Id = 1;
            personWithoutConstructor.Name = "John";
            personWithoutConstructor.Title = "Captain";

            Console.WriteLine(personWithoutConstructor.Name);
            //Console.WriteLine(personWithoutConstructor);          
            //Console.WriteLine(personWithoutConstructor.ToString());          
            Console.WriteLine(personWithoutConstructor.Id);          
            Console.WriteLine(personWithoutConstructor.Title);          
            //Console.WriteLine(personWithoutConstructor.GetType());          

            Console.ReadLine();
        }

        public struct Person
        {
            public string Name;
            public int Id;
            public string Title;

            //Can use a constructor
            //public Person(string title, int id, string name)
            //{
            //    Title= title;
            //    Id= id;
            //    Name= name;
            //}
        }
    }
}
