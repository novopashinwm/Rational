using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rational
{
    public class Rational
    {
        public long A { get; private set; }
        public long B { get; private set; }

        public Rational(long a, long b)
        {
            A = a;

            if (b == 0) 
            {
                throw new DivideByZeroException("Знаменатель не может быть равен нулю!");
            }            
            B = b;
        }

        public long this[int i] 
        {
            get {
                if (i == 0) return A;
                if (i == 1) return B;
                throw new ArithmeticException("Указан не правильный индекс!");
            }
        }

        public static long GCD(long a, long b) 
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        public override string ToString()
        {
            return $"{A}/{B}";
        }

        public static Rational operator +(Rational x, Rational y) 
        {
            long a_new = x.A * y.B + y.A * x.B;
            long b_new = x.B * y.B;
            long mult = GCD(a_new, b_new);
            return new Rational(a_new / mult, b_new / mult);
        }

        public static Rational operator -(Rational x, Rational y)
        {
            long a_new = x.A * y.B - y.A * x.B;
            long b_new = x.B * y.B;
            long mult = GCD(a_new, b_new);
            return new Rational(a_new / mult, b_new / mult);
        }

        public static Rational operator *(Rational x, Rational y)
        {
            long a_new = x.A * y.A;
            long b_new = x.B * y.B;
            long mult = GCD(a_new, b_new);
            return new Rational(a_new / mult, b_new / mult);
        }

        public static Rational operator /(Rational x, Rational y)
        {
            long a_new = x.A * y.B;
            long b_new = x.B * y.A;
            long mult = GCD(a_new, b_new);
            return new Rational(a_new / mult, b_new / mult);
        }

    }
}
