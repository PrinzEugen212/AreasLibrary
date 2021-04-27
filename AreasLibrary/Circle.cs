using System;

namespace AreasLibrary
{
    public class Circle : IShape
    {
        double _radius;
        private double _area;

        public double Radius 
        { 
            get 
            {
                return _radius; 
            } 
            set 
            { 
                _radius = value;
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
        public Circle(double r)
        {
            if (r <= 0)
            {
                throw new Exception("Радиус должен быть больше нуля");
            }
            _radius = r;
            _area = CalculateArea();
        }

        public double CalculateArea()
        {
            return Math.Pow(_radius, 2) * Math.PI;
        }
    }
}
