using GeometricShape.Const;

namespace GeometricShape.Calculation
{
    internal static class Handler
    {
        internal static double ShapeAnalysis(ICollection<double> sides)
        {
            double area = sides.Count switch
            {
                Shape.Circle => Calculate.Circle(sides),

                Shape.Triangle => Calculate.Triangle(sides),

                _ => throw new InvalidOperationException("Unknow Shape")
            };

            return area;
        }
    }
}
