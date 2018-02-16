using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    public interface IShape {
        // We want to control the measures via constructors to limit the number of measures in certain shapes like triangles
        IEnumerable<double> Measures { get; }
        bool IsValidShape();
        double ComputeArea();
        double ComputePerimeter();
    }

    public class Triangle: IShape
    {

        public IEnumerable<double> Measures { get; private set; }

        public Triangle(double edge1, double edge2, double edge3)
        {
            var measures = new List<double> { edge1, edge2, edge3 };

            if (measures.Any(m => m <= 0) || measures.Any(m => 2 * m >= measures.Sum()))
            {
                throw new InvalidTriangleException(measures);
            }

            this.Measures = measures;
        }

        public bool IsValidShape()
        {
            return Measures.All(m => m > 0) && Measures.All(m => 2 * m < Measures.Sum());
        }

        public double ComputeArea()
        {
            double halfP = Measures.Sum() / 2d;

            var herons = Measures.ToList();
            herons.Insert(0, halfP);

            return Math.Round(Math.Sqrt(herons.Aggregate((r, e) => r * (halfP - e))), 2);
        }

        public double ComputePerimeter()
        {
            return Measures.Sum();
        }

        // This method is created to serve the purpose of the requirement only
        // as the requirement asks for the method to have 3 inputs and 1 output
        // Ideally, area computation should be called via the instance method instead
        // as this is more object-oriented
        public static double ComputeArea(double edge1, double edge2, double edge3) {
            var triangle = new Triangle(edge1, edge2, edge3);
            return triangle.ComputeArea();
        }
    }

    public class InvalidTriangleException : Exception
    {
        public InvalidTriangleException(string message)
            : base(message)
        {
        }

        public InvalidTriangleException(IEnumerable<double> measures)
            : base(string.Format("Invalid triangles: {0}", string.Join(", ", measures)))
        {            
        }
    }
}
