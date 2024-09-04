namespace GeometricShape.Test.Common
{
    public class TestCheckCommandBase
    {
        public bool IsRightTriangle(ICollection<double> sides)
        {
            if (sides.Count != 3)           
                return false;
            
            List<double> sortedSides = sides.Order().ToList();

            bool result = Math.Pow(sortedSides[0], 2) + Math.Pow(sortedSides[1], 2) == Math.Pow(sortedSides[2], 2);

            return result;
        }
    }
}
