using GeometricShape.Test.Common;

namespace GeometricShape.Test.Calculation
{
    public class CalculateTest : TestCalculationCommandBase
    {
        [Fact]
        public void Circle_RadialArea()
        {
            //Arrage
            List<double> sides = new List<double> { 7 };
            double expResult = 153.94;

            //Act
            double area = Circle(sides);
            double result = Math.Round(area, 2, MidpointRounding.AwayFromZero);

            //Assert
            Assert.Equal(expResult, result);
        }

        [Fact]
        public void Triangle_ThreeSidedArea()
        {
            //Arrage
            List<double> sides = new List<double> { 5, 10, 6 };
            double expResult = 11.4;

            //Act
            double area = Triangle(sides);
            double result = Math.Round(area, 2, MidpointRounding.AwayFromZero);

            //Assert
            Assert.Equal(expResult, result);
        }
    }
}
