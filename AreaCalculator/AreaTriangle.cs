using System;

namespace AreaCalculator
{
    public class AreaTriangle
    {
        public double A;
        public double B;
        public double C;

        public AreaTriangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        private double HalfMeterTriangle()
        {
            return (A + B + C) / 2;
        }

        public double CalculateArea()
        {
            var p = HalfMeterTriangle();
            var area = p * (p - A) * (p - B) * (p - C);
            if (area == 0)
            {
                Console.WriteLine("Такой треугольник не существует");
                return 0;
            }

            if ( Math.Abs(A*A - (B*B + C*C)) < 0.0001 || Math.Abs(B*B - (A*A + C*C)) < 0.0001 || Math.Abs(C*C - (A*A + B*B)) < 0.0001)
                Console.WriteLine("Данный треугольник является прямоугольным");
            
            return Math.Sqrt(area);
        }
    }
}