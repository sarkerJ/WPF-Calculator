using System;

namespace Calculator
{
    public class Calculators //make all the methods static
    {

        public static int Add(int a, int b) 
        {
            return a + b;
        }

        public static int Subtract(int a, int b) 
        {
            return a - b;
        }

        public static int Multiply(int a, int b) 
        {
            return a * b;
        }

        public static int Divide(int a, int b) 
        {
            if (b == 0) throw new DivideByZeroException("cannot divide by 0");
            else
            {
                return a / b;
            }
        }

        public static int Modulus(int a, int b) 
        {
            return a % b;
        }

        public static int PowerOfTwo(int a)
        {
            return (int)Math.Pow(a,2);
        }

        public static int PowerOf(int a, int b)
        {
            return (int)Math.Pow(a, b);
        }

        public static int Root(int a)
        {
            return (int)Math.Sqrt(a);
        }
    }
}
