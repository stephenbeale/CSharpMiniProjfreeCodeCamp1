using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMiniProjfreeCodeCamp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Continue from: https://youtu.be/GlGpSQsS8uc?si=WOjoNTeclBupEypC&t=1541

            int age = 23;
            age++;
            Console.WriteLine(age);
            //All do the same, but below can do calculations, too
            age = age + 1;
            age += 1;
            age--;
            Console.WriteLine(age);
            
            //Mult by 3
            age *= 3;
            Console.WriteLine(age);
            
            //Divides by 10
            age /= 10;
            Console.WriteLine(age);
            Console.ReadLine();

        }
    }
}
