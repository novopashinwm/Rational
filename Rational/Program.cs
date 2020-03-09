using System;

namespace Rational
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational ra = new Rational(1, 3);
            Rational rb = new Rational(1, 5);
            Console.WriteLine(ra+rb);
            Console.WriteLine(ra-rb);
            Console.WriteLine(ra * rb);
            Console.WriteLine(ra/rb);
            Rational d = new Rational(1, 6);
            Rational e = new Rational(1, 6);
            Console.WriteLine($"{d} +{e} ={d+e}");
            Console.WriteLine(d[0]);
            Console.WriteLine(d[1]);
            Console.ReadKey();
        }
    }
}
