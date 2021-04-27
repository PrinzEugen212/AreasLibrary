using System;

namespace AreasLibrary
{
    public class Triangle : IShape
    {
        double _a, _b, _c;
        private double _area;

        public double A
        {
            get
            {
                return _a;
            }
            private set
            {
                _a = value;
                CalculateArea();
            }
        }
        public double B
        {
            get
            {
                return _b;
            }
            private set
            {
                _b = value;
                CalculateArea();
            }
        }
        public double C
        {
            get
            {
                return _c;
            }
            private set
            {
                _c = value;
                CalculateArea();
            }
        }
        public double Area
        {
            get
            {
                return _area;
            }
        }
        public bool IsRectangular
        {
            get
            {
                return CheckRectangular();
            }
        }
        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new Exception("Неверное значение стороны/сторон треугольника - должно быть > 0");
            }
            try
            {
                CheckRectangular();
            }
            catch (Exception)
            {
                throw new Exception("Треугольника с такими сторонами не существует!");
            }
            _a = a;
            _b = b;
            _c = c;
            _area = CalculateArea();
        }

        public double CalculateArea()
        {
            double area, perimeter;
            perimeter = (_a + _b + _c) / 2;
            area = Math.Sqrt(perimeter * (perimeter - _a) * (perimeter - _b) * (perimeter - _c));
            if (area == double.NaN)
            {
                throw new Exception("Такого треугольника не существует!");
            }
            return area;
        }
        public bool CheckRectangular()
        {
            double max = _a, other1 = _b, other2 = _c;
            if (_b > max)
            {
                max = _b;
                other1 = _a; other2 = _c;
            }
            if (_c > max)
            {
                max = _c;
                other1 = _b; other2 = _a;
            }
            double result = Math.Pow(max, 2) - (Math.Pow(other1, 2) + Math.Pow(other2, 2));
            if (result < 0)
            {
                throw new Exception();
            }
            return result < 0.0000001;
        }
    }
}
