using System;

namespace Fraction_class
{
    class Program
    {
        class Fraction
        {
            private int numerator, denominator;
            public Fraction()
            {
                numerator = 0;
                denominator = 0;
            }
            public Fraction(int num, int don)
            {
                numerator = num;
                denominator = don;
            }
            public Fraction Multiply(Fraction other)
            {
                int nume = numerator * other.numerator;
                int denom = denominator * other.denominator;
                Fraction multiply = new Fraction(nume, denom);
                return multiply;

            }
            public Fraction Add(Fraction other)
            {
                int nume = (numerator * other.denominator + other.numerator * denominator);
                int denom = denominator * other.denominator;
                Fraction add = new Fraction(nume, denom);
                return add;
            }
            public Fraction Minus(Fraction other)
            {
                int nume = (numerator * other.denominator - other.numerator * denominator);
                int denom = denominator * other.denominator;
                Fraction minus = new Fraction(nume, denom);
                return minus;
            }
            public Fraction divide(Fraction other)
            {
                int nume = numerator * other.denominator;
                int denom = denominator * other.numerator;
                Fraction divide = new Fraction(nume, denom);
                return divide;
            }
            public void Simpilify()
            {
                int divisor = 0;
                for (int i = numerator; i >= 1; i--)
                {
                    if (numerator % i == 0 && denominator % i == 0)
                    {
                        divisor = i;
                        break;
                    }
                }
                if (divisor != 0)
                {
                    numerator /= divisor;
                    denominator /= divisor;
                }
            }
            public void Print()
            {
                if (denominator == 0)
                {
                    Console.WriteLine("The denominator cannot be 0");
                    return;
                }
                if (numerator % denominator == 0) Console.WriteLine(numerator);
                else Console.WriteLine($"{numerator}/{denominator}");
            }
        }

        static void Main(string[] args)
        {

            Fraction f1 = new Fraction(5,10 );
            Fraction f2 = new Fraction(4, 15);
            Fraction result1 = f1.Multiply(f2);
            result1.Simpilify();
            result1.Print();
            Fraction result2 = f1.Add(f2);
            result2.Simpilify();
            result2.Print();
            Fraction result3 = f1.divide(f2);
            result3.Simpilify();
            result3.Print();
            Fraction result4 = f1.divide(f2);
            result4.Simpilify();
            result4.Print();
        }
    }
}
