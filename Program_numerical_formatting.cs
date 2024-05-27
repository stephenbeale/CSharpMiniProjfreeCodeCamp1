using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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
            // https://youtu.be/GlGpSQsS8uc?si=QMidGYoWBaMcy33O&t=5764

            double value = 1000D / 12.34D;

            Console.WriteLine(value);
            //Pattern to format to - 0.00 outputs to 2 decimal places
            Console.WriteLine(string.Format("{0:0.00}, {1}, {2}", value, 1000, 8));
           
            Console.ReadLine();
        }
    }
}
