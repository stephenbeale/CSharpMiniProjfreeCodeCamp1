using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CSharpMiniProjfreeCodeCamp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://youtu.be/GlGpSQsS8uc?si=h0Jjai45pv6P6OW6&t=2348

            const double vat = 20;
            const double percentVat = vat / 100D;
            const string version = "v1.0";

            int balance = 1000;

            Console.WriteLine($"VAT is {vat}%");
            Console.WriteLine(balance * (vat / 100D));
            Console.WriteLine(balance * percentVat);            


            

            Console.ReadLine();
        }
    }
}
