using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    internal class Handler
    {
        protected internal async Task ShapeAnalysis(ICollection<double> sides)
        {

        }
        private double Circle(Figure circle)
        {
            double area = Math.PI * Math.Pow(circle.Radius, (double)2);

            return area;
        }
        private double Triangle(Figure triangle)
        {
            double perimeter = triangle.SideA + triangle.SideB + triangle.SideC;
            double sp = perimeter / 2;

            double area = Math.Sqrt(sp * (sp - triangle.SideA) * (sp - triangle.SideB) * (sp - triangle.SideC));

            return area;
        }
    }
}
