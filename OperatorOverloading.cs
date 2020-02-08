using System;

namespace Learning {
    public readonly struct Fraction {
        private readonly int num;
        private readonly int den;
        public Fraction(int numerator, int denominator) {
            if (denominator == 0) {
                throw new ArgumentException("Denominator cannot be zero", nameof(denominator));
            }
            num = numerator;
            den = denominator;
        }

        public static Fraction operator +(Fraction a) => a;
        public static Fraction operator -(Fraction a) => new Fraction(-a.num, a.den);
    }
}