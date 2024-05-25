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
            // https://youtu.be/GlGpSQsS8uc?si=59z9daoQH2qsHdS-&t=4462

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"i is {i}");
            }
            
            Console.ReadLine();
        }
    }
}
