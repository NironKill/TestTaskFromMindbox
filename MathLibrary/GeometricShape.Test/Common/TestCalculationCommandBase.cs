namespace GeometricShape.Test.Common
{
    public class TestCalculationCommandBase
    {
        public double Circle(ICollection<double> sides)
        {
            double radius = default;

            foreach (double side in sides)
            {
                radius = side;
            }

            double area = Math.PI * Math.Pow(radius, 2);

            return area;
        }
        public double Triangle(ICollection<double> sides)
        {
            double a = default;
            double b = default;
            double c = default;

            foreach (double side in sides)
            {
                if (a <= 0)
                    a = side;
                else if (b <= 0)
                    b = side;
                else if (c <= 0)
                    c = side;
            }

            double perimeter = a + b + c;
            double sp = perimeter / 2;

            double area = Math.Sqrt(sp * (sp - a) * (sp - b) * (sp - c));

            return area;
        }
    }
}
