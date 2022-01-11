using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра");

            double lenEdge = Convert.ToDouble(Console.ReadLine());
            double v, s = 0;

            CalcVSCube(lenEdge,out v,out s);

            Console.WriteLine("Объём={0:f2}, площадь поверхности={1:f2}", v, s);
            Console.ReadKey();
        }

        static void CalcVSCube(double lenEdge, out double V, out double S)
        {
            V = Math.Pow(lenEdge, 3);
            S = Math.Pow(lenEdge, 2) * 6;
        }
    }
}
