using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleApp
{
    public class Edge
    {
        public Point Point1;
        public Point Point2;

        public Edge(Point point1, Point point2)
        {
            Point1 = point1;
            Point2 = point2;
        }

        public double GetLenght()
        {
            double a = Math.Sqrt(Math.Pow((Point1.X + Point2.X), 2.0) + Math.Pow(Point1.Y + Point2.Y, 2.0));

            return a;
        }
    }
}
