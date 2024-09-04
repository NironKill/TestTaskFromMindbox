using GeometricShape.Test.Common;

namespace GeometricShape.Test.Check
{
    public class ShapeCheckTest : TestCheckCommandBase
    {
        [Fact]
        public void IsRightTriangle_False()
        {
            //Arrage
            List<double> sides = new List<double> { 16, 7, 12 };
            bool expResult = false;

            //Act
            bool result = IsRightTriangle(sides);

            //Assert
            Assert.Equal(expResult, result);
        }

        [Fact]
        public void IsRightTriangle_True()
        {
            //Arrage
            List<double> sides = new List<double> { 4, 5, 3 };
            bool expResult = true;

            //Act
            bool result = IsRightTriangle(sides);
          
            //Assert
            Assert.Equal(expResult, result);
        }
    }
}
