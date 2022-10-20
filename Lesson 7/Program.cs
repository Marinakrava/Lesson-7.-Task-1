using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    internal class Program
    {
        static double CalcS(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p*(p-a)* (p - b)* (p - c));
             
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины сторон первого треугольника");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double z1 = Convert.ToDouble(Console.ReadLine());
            double S1 = CalcS(x1, y1, z1);
            Console.WriteLine("Введите длины сторон второго треугольника");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double z2 = Convert.ToDouble(Console.ReadLine());
            double S2 = CalcS(x2, y2, z2);

            if (S1 > S2)
                Console.WriteLine("Площадь первого треугольника больше = {0}", S1);
            else
                if (S1 < S2)
                Console.WriteLine("Площадь второго треугольника больше и = {0}",S2);
            else
                Console.WriteLine("Площади треугольников равны и = {0}", S2);
            Console.ReadKey();

        }
    }
}
