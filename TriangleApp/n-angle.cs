using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleApp
{
    public class n
    {
        public Point[] Points;

         public n(Point[] points)
        {
            Points = points;
        }

        public double GetPerimetr()
        {
            int n = Points.Length;

            Edge[] edges = new Edge[n];

            for (int i = 0; i < n - 1; i++)
            {
                Edge edge = new Edge(Points[i], Points[i + 1]);

                edges[i] = edge;
            }

            Edge edgeFirst = new Edge(Points[0], Points[n-1]);
            edges[n-1] = edgeFirst;

             double p = 0;

            for (int i = 0; i < n; i++)
            {
                p += edges[i].GetLenght();
            }
            
            return p;
           
        }


    }
}
