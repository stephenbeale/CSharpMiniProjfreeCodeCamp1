using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
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
            // https://youtu.be/GlGpSQsS8uc?si=QMidGYoWBaMcy33O&t=5764
            Console.Write("Enter a number: ");
            string numInput = Console.ReadLine();
            int num = 0;

            int.TryParse(numInput, out num);
            Console.WriteLine(num);
            Console.Write(Convert.ToInt32(numInput));
            
            Console.ReadLine();
        }
    }
}
