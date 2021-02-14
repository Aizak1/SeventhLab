using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Polinomial polinomial1 = new Polinomial(new double[] { 1, -3, 5 });
            Polinomial polinomial2 = new Polinomial(new double[] { 3,-1 });
            var result = polinomial1 / polinomial2;
            result.Item1.Output();
        }
    }
}
