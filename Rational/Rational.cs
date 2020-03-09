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
            long mult = Rational.GCD(A, B);
            A /= mult;
            B /= mult;
        }

        public long this[int i] 
        {
            get {
                if (i == 0) return A;
                if (i == 1) return B;
                throw new IndexOutOfRangeException("Указан не правильный индекс!");
            }
        }

        public static long GCD(long a, long b) 
        {
            return Math.Abs(b) == 0 ? Math.Abs(a) 
                : GCD(Math.Abs(b), Math.Abs(a) % Math.Abs(b));
        }

        public override string ToString()
        {
            return $"{A}/{B}";
        }

        public static Rational operator +(Rational x, Rational y) 
        {
            long a_new = x.A * y.B + y.A * x.B;
            long b_new = x.B * y.B;
            return new Rational(a_new ,b_new);
        }

        public static Rational operator *(Rational x, int n) {
            return new Rational(x.A * n, x.B);
        }

        public static Rational operator -(Rational x) 
        {
            return new Rational(-x.A, x.B);
        }
        public static Rational operator -(Rational x, Rational y)
        {
            return x + (-y);
        }

        public static Rational operator *(Rational x, Rational y)
        {
            long a_new = x.A * y.A;
            long b_new = x.B * y.B;
            return new Rational(a_new, b_new);
        }

        public static Rational operator /(Rational x, Rational y)
        {
            long a_new = x.A * y.B;
            long b_new = x.B * y.A;
            return new Rational(a_new, b_new);
        }

       

    }
}
