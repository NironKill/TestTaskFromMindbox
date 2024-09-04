using GeometricShape.Test.Common.Const;

namespace GeometricShape.Test.Common
{
    public class TestHandlerCommandBase
    {
        public double ShapeAnalysis(ICollection<double> sides)
        {
            double area = sides.Count switch
            {
                TestShape.Circle => 1,

                TestShape.Triangle => 3,

                _ => 10
            };

            return area;
        }
    }
}
