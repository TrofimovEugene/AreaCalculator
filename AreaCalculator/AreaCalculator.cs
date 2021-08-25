using System;
using System.Collections.Generic;

namespace AreaCalculator
{
    public class AreaCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные фигуры, радиус круга или стороны треугольника через пробел");
            var str = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(str))
            {
                var input = str.Split(' ');
                var sides = new List<double>();
                foreach (var side in input)
                {
                    if (double.TryParse(side, out var result) && result > 0)
                        sides.Add(result);
                    else
                    {
                        Console.WriteLine("Сторона или радиус должны быть положительными числами");
                        break;
                    }
                }

                CalculateArea(sides);
            }
        }

        public static void CalculateArea(List<double> sides)
        {
            var area = 0.0;
            switch (sides.Count)
            {
                case 1:
                {
                    var areaCircle = new AreaCircle(sides[0]);
                    area = areaCircle.CalculateArea();
                    break;
                }
                case 3:
                {
                    var areaTriangle = new AreaTriangle(sides[0], sides[1], sides[2]);
                    area = areaTriangle.CalculateArea();
                    break;
                }
            }

            if (area > 0)
                Console.WriteLine($"Площадь фигуры равна: {area}");
        }
    }
}