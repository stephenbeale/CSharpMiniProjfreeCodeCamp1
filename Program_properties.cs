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
            // https://youtu.be/GlGpSQsS8uc?si=rdy9HinTWts0TncC&t=27848

            //Person person = new Person("Mr", 1, "Steve");
            //Person person = new Person();
            //Can assign here without constructor
            //person.Id = 1;
            //person.Name = "Rich";
            //person.Title = "Test";

            Person person1= new Person(2, "Stu", "Squire");



            Console.WriteLine(person1.Name);
            //Console.WriteLine(personWithoutConstructor);          
            //Console.WriteLine(personWithoutConstructor.ToString());          
            Console.WriteLine(person1.Id);          
            Console.WriteLine(person1.Title);          
            //Console.WriteLine(personWithoutConstructor.GetType());          

            Console.ReadLine();
        }

        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Title { get; set; }

            public Person(int id, string name, string title)
            {
                Id= id;
                Name= name;
                Title= title;
            }
        }

    }
}
