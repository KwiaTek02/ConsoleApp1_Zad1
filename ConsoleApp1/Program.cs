using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b1 = 8;
            short s1 = 2;
            Int16 i16 = 13;

            Console.WriteLine(Foo(b1));
            Console.WriteLine(Foo(s1));
            Console.WriteLine(Foo(i16));
            Console.WriteLine(s1 + b1 + i16);
            
            Auto auto1 = new Auto("Dodge", 2015);
            Auto auto2 = new Auto("Dodge", 2015);
            Console.WriteLine("Czy auto1 to auto2? (przez ==): " + (auto1 == auto2));
            Console.WriteLine("Czy auto1 to auto2? (przez przeciążenie metody Equals): " + auto1.Equals(auto2));

            Console.ReadKey();

        }

        static int Foo(Int32 x)
        {
            
            return x + 30; 

        }
    }
    class Auto
    {
        public string Marka { get; }
        public int Rok { get; }

        public Auto(string marka, int rok)
        {
            this.Marka = marka;
            this.Rok = rok;
        }

        public bool Equals(Auto auto)
        {
            return auto.Marka == this.Marka && auto.Rok == this.Rok;
        }
    }
}      