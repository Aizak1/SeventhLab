using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public class Polinomial: IComparable<Polinomial>
    {
       
        private readonly double[] coefficients;
       

        public Polinomial(double[] coefficients)
        {
            this.coefficients = coefficients;
        }

        public void Output()
        {
           
            for (int i = 0; i <coefficients.Length-1; i++)
            {
                Console.Write($"{coefficients[i]:F2}X ^ {i+1} + ");
            }
            Console.Write($"{coefficients[coefficients.Length-1]:F2}");
            Console.WriteLine();
        }

       

        public int CompareTo(Polinomial that)
        {
            if(this.coefficients.Length == that.coefficients.Length)
            {
                for (int i = 0; i < that.coefficients.Length; i++)
                {
                    return 1;
                }
            }
            
                return 0;
        }

        public static Polinomial operator +(Polinomial polinomial1, Polinomial polinomial2)
        {
            int min = Math.Min(polinomial1.coefficients.Length, polinomial2.coefficients.Length);
            int max = Math.Max(polinomial1.coefficients.Length, polinomial2.coefficients.Length);

            bool IsLonger = polinomial1.coefficients.Length > polinomial2.coefficients.Length;

            double[] result = new double[max];

            for (int i = 0; i < min; i++)
            {
                result[result.Length - 1 - i] = polinomial1.coefficients[polinomial1.coefficients.Length - 1 - i] +
                                                polinomial2.coefficients[polinomial2.coefficients.Length - 1 - i];
            }
            if (min < max)
            {
                for (int i = min; i < max; i++)
                {
                    if (IsLonger)
                        result[result.Length - 1 - i] = polinomial1.coefficients[polinomial1.coefficients.Length - 1 - i];
                    else
                        result[result.Length - 1 - i] = polinomial2.coefficients[polinomial2.coefficients.Length - 1 - i];
                }
            }

            return new Polinomial(result);
        }
        public static Polinomial operator -(Polinomial polinomial1, Polinomial polinomial2)
        {
            int min = Math.Min(polinomial1.coefficients.Length, polinomial2.coefficients.Length);
            int max = Math.Max(polinomial1.coefficients.Length, polinomial2.coefficients.Length);

            bool IsLonger = polinomial1.coefficients.Length > polinomial2.coefficients.Length;

            double[] result = new double[max];

            for (int i = 0; i < min; i++)
            {
                result[result.Length - 1 - i] = polinomial1.coefficients[polinomial1.coefficients.Length - 1 - i] -
                                                polinomial2.coefficients[polinomial2.coefficients.Length - 1 - i];
            }
            if (min < max)
            {
                for (int i = min; i < max; i++)
                {
                    if (IsLonger)
                        result[result.Length - 1 - i] = polinomial1.coefficients[polinomial1.coefficients.Length - 1 - i];
                    else
                        result[result.Length - 1 - i] = -polinomial2.coefficients[polinomial2.coefficients.Length - 1 - i];
                }
            }

            return new Polinomial(result);
        }
        public static Polinomial operator *(Polinomial polinomial1, double number) =>
            new Polinomial(polinomial1.coefficients.Select(x => x * number).ToArray());

        public static (Polinomial, Polinomial) operator /(Polinomial polinomial1, Polinomial polinomial2)
        {
            double[] pol1 = polinomial1.coefficients.Reverse().ToArray();
            double[] pol2 = polinomial2.coefficients.Reverse().ToArray();

            double[] quotient, remainder;
            if (pol1.Last() == 0)
            {
                throw new ArithmeticException("Старший член многочлена делимого не может быть 0");
            }
            if (pol2.Last() == 0)
            {
                throw new ArithmeticException("Старший член многочлена делителя не может быть 0");
            }
            remainder = (double[])pol1.Clone();
            quotient = new double[remainder.Length - pol2.Length + 1];
            for (int i = 0; i < quotient.Length; i++)
            {
                double coeff = remainder[remainder.Length - i - 1] / pol2.Last();
                quotient[quotient.Length - i - 1] = coeff;
                for (int j = 0; j < pol2.Length; j++)
                {
                    remainder[remainder.Length - i - j - 1] -= coeff * pol2[pol2.Length - j - 1];
                }
            }
            return (new Polinomial(quotient.Reverse().ToArray()), new Polinomial(remainder.Reverse().ToArray()));
        }
       

    }
}
