﻿using System;
using System.Collections.Generic;
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

            //Continue from: https://youtu.be/GlGpSQsS8uc?si=sedUOcFgDGRhaAEa&t=2095

            //Var must be initialised
            var age = 23;
            Console.WriteLine(age);
            
            var bigNumber = 300000L;
            Console.WriteLine(bigNumber);
            
            var negative = -55.2D;
            Console.WriteLine(negative);

            var precision = 5.000001F;
            Console.WriteLine(precision);

            var money = 14.99M;
            Console.WriteLine(money);

            Console.ReadLine();
        }
    }
}
