using System;

namespace AreasLibrary
{
    public static class Area
    {
        public static double CalculateTriangleArea(double a, double b, double c)
        {
            double area, perimeter;
            perimeter = (a + b + c) / 2;
            area = Math.Sqrt(perimeter * (perimeter - a) * (perimeter - b) * (perimeter - c));
            if (area == double.NaN)
            {
                throw new Exception("Такого треугольника не существует!");
            }
            return area;
        }
        public static double CalculateCircleArea(double r)
        {
            return Math.Pow(r, 2) * Math.PI;
        }
        public static double CalculateShapeArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}
