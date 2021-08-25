using System;

namespace AreaCalculator
{
    public class AreaCircle
    {
        public double R;

        public AreaCircle(double r)
        {
            R = r;
        }

        public double CalculateArea()
        {
            if (R > 0)
                return Math.PI * R * R;
            
            return 0;
        }
    }
}