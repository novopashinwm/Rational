using System;

namespace Rational
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational ra = new Rational(1, 3);
            Rational rb = new Rational(1, 5);
            Console.WriteLine($"{ra}+{rb} = {ra+rb}");
            Console.WriteLine($"{ra}-{rb} = {ra-rb}");
            Console.WriteLine($"{ra} * {rb} = {ra * rb}");
            Console.WriteLine($"{ra} / {rb} = {ra/rb}");
            Rational d = new Rational(1, 6);
            Rational e = new Rational(1, 6);
            Console.WriteLine($"{d} +{e} ={d+e}");
            Console.WriteLine(d[0]);
            Console.WriteLine(d[1]);
            Rational f = new Rational(-2, 6);
            Console.WriteLine($"{f}");
            double num = 1.455;
            Console.WriteLine(num.ToRational());
            Console.ReadKey();
        }
        
    }
    public static class Foo
    {
        public static Rational ToRational(this double num)
        {
            double ost = num % 1.0;
            double part = num -ost;
           
            int n = ost.ToString().Length - 2;
            int m = (int) Math.Pow(10, n);
            
            long numerator = (long) ((double)ost * m);
            long denominator = m;
            if (part > 0) {
                numerator += (long) ((double) part * denominator);
            }

            return new Rational(numerator  , denominator);
        }
    }
}
