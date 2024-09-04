namespace GeometricShape.Check
{
    public static class ShapeCheck
    {
        public static bool IsRightTriangle(ICollection<double> sides)
        {
            if (sides.Count != 3)
            {
                Console.WriteLine("It's not a right triangle");
                return false;
            }

            List<double> sortedSides = sides.Order().ToList();

            bool result = Math.Pow(sortedSides[0], 2) + Math.Pow(sortedSides[1], 2) == Math.Pow(sortedSides[2], 2);

            if (result is true)
                Console.WriteLine("Is a right triangle");
            else
                Console.WriteLine("It's not a right triangle");

            return result;
        }
    }
}
