using System;

namespace AreasLibrary
{
    public class Circle : IShape
    {
        double _radius;

        public double Radius 
        { 
            get 
            {
                return _radius; 
            } 
            set 
            {
                if (value <= 0)
                {
                    throw new IncorrectCircleException("Радиус должен быть больше нуля");
                }
                _radius = value;
            } 
        }
        public Circle(double r)
        {
            Radius = r;
        }

        public double CalculateArea()
        {
            return Math.Pow(_radius, 2) * Math.PI;
        }
    }
}
