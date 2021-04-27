using System;

namespace AreasLibrary
{
    public static class Area
    {
        public static double CalculateShapeArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}
