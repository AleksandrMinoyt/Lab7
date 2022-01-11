using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону A первого треугольника");
            int sideA1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону B первого треугольника");
            int sideB1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону C первого треугольника");
            int sideC1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите сторону A второго треугольника");
            int sideA2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону B второго треугольника");
            int sideB2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону C второго треугольника");
            int sideC2 = Convert.ToInt32(Console.ReadLine());

            if (CalcSquare(sideA1, sideB1, sideC1) == CalcSquare(sideA2, sideB2, sideC2))
            {
                Console.WriteLine("треугольники равны");
            }
            else
            {
                if (CalcSquare(sideA1, sideB1, sideC1) > CalcSquare(sideA2, sideB2, sideC2))
                {
                    Console.WriteLine("Больше первый треугольник");
                }
                else
                {
                    Console.WriteLine("Больше второй треугольник");
                }
            }

            Console.ReadKey();
        }

        static double CalcSquare(int sideA, int sideB, int sideC)
        {
            double perimeter = sideA + sideB + sideC;

            double p = perimeter / 2;

            double square = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));

            return square;
        }
    }
}
