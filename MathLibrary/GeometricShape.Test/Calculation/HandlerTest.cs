using GeometricShape.Test.Common;

namespace GeometricShape.Test.Calculation
{
    public class HandlerTest : TestHandlerCommandBase
    {
        [Fact]
        public void ShapeAnalysis_Circle()
        {
            //Arrage
            ICollection<double> sides = new double[1];
            double expResult = 1;

            //Act
            double result = ShapeAnalysis(sides);

            //Assert
            Assert.Equal(expResult, result);
        }

        [Fact]
        public void ShapeAnalysis_Triangle()
        {
            //Arrage
            ICollection<double> sides = new double[3];
            double expResult = 3;

            //Act
            double result = ShapeAnalysis(sides);

            //Assert
            Assert.Equal(expResult, result);
        }

        [Fact]
        public void ShapeAnalysis_Unknow()
        {
            //Arrage
            ICollection<double> sides = new double[53];
            double expResult = 10;

            //Act
            double result = ShapeAnalysis(sides);

            //Assert
            Assert.Equal(expResult, result);
        }
    }
}
