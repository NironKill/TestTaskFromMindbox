namespace GeometricShape.Calculation
{
    public static class MathShape
    {
        public static double Area(ICollection<double> sides) => Handler.ShapeAnalysis(sides);
    }
}
