using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CSharpMiniProjfreeCodeCamp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://youtu.be/GlGpSQsS8uc?si=va5HeUwvQu_27L2P&t=5423

            var i = 2;
            var myNum = 30;

            Console.WriteLine("While loop");
            while (i != myNum)
            {
                Console.WriteLine($"i is {i}");
                i++;
            }

            Console.WriteLine("Do-while");

            i = 2;
            myNum = 30;

            do
            {
                //Condition is irrelevant first time
                Console.WriteLine($"i is {i}");
                i++;
            } while (i != myNum);   

            Console.ReadLine();
        }
    }
}
