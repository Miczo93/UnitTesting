using System;
namespace Calculator.Libarary
{
    public class Calculator
    {
        public static int Divide(int n, int d)
        {
            if (d == 0)
            {
                throw new DivideByZeroException("Dzielisz przez 0!");
            }
            int res = n / d;
            return res;
        }
        public static int Add(int first, int second)
        {
            int res = first + second;
            return res;
        }
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        public static void Test()
        {
        }

        private static bool IsPos(int number)
        {
            return number > 0;
        }

        private bool IsPosNonStatic(int number)
        {
            return number > 0;
        }

        public static int AddOnlyPos(int first, int second)
        {
            if (IsPos(first)&& IsPos(second))
            {
                int res = first + second;
                return res;
            }
            else
            {
                throw new ArgumentException("Only + numbers");
            }
        }

        public int AddOnlyPosNonStatic(int first, int second)
        {
            if (IsPosNonStatic(first) && IsPosNonStatic(second))
            {
                int res = first + second;
                return res;
            }
            else
            {
                throw new ArgumentException("Only + numbers");
            }
        }

    }

}
