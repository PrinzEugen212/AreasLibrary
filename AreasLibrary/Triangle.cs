using System;

namespace AreasLibrary
{
    public class Triangle : IShape
    {
        double _a, _b, _c;

        public double A
        {
            get
            {
                return _a;
            }
            private set
            {
                _a = value;
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
            ChangeSides(a, b, c);
        }

        public void ChangeSides(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new IncorrectTriangleException("Неверное значение стороны/сторон треугольника - должно быть > 0");
            }
            CheckCorrect(a, b, c);
            _a = a;
            _b = b;
            _c = c;
        }

        public double CalculateArea()
        {
            double area, perimeter;
            perimeter = (_a + _b + _c) / 2;
            area = Math.Sqrt(perimeter * (perimeter - _a) * (perimeter - _b) * (perimeter - _c));
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
            return Math.Pow(max, 2) - (Math.Pow(other1, 2) + Math.Pow(other2, 2)) < 0.0000001;
        }
        private void CheckCorrect(double a, double b, double c)
        {
            if (a >= b + c || b >= a + c || c >= a + b)
            {
                throw new IncorrectTriangleException("Треугольника с такими сторонами не существует!");
            }
        }
    }
}
