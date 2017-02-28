using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleApp
{
    public class Triangle
    {
        public Point P1, P2, P3;

       

        public Triangle(Point p1, Point p2, Point p3)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
        }

        

        public double GetPerimetr()
        {
            Edge edge1 = new Edge(P1, P2);
            Edge edge2 = new Edge(P1, P3);
            Edge edge3 = new Edge(P2, P3);

            double p = edge1.GetLenght() + edge2.GetLenght() + edge3.GetLenght();

            return p;
        }

        public double GetSquare()
        {
            Edge edge1 = new Edge(P1, P2);
            Edge edge2 = new Edge(P1, P3);
            Edge edge3 = new Edge(P2, P3);

            double a = edge1.GetLenght();
            double b = edge2.GetLenght();
            double c = edge3.GetLenght();

            double p = (a + b + c) / 2;

            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return S;
        }

        public bool IsRight()
        {
            Edge edge1 = new Edge(P1, P2);
            Edge edge2 = new Edge(P1, P3);
            Edge edge3 = new Edge(P2, P3);

            double a = edge1.GetLenght();
            double b = edge2.GetLenght();
            double c = edge3.GetLenght();

            if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsIsosceles()
        {
            Edge edge1 = new Edge(P1, P2);
            Edge edge2 = new Edge(P1, P3);
            Edge edge3 = new Edge(P2, P3);

            double a = edge1.GetLenght();
            double b = edge2.GetLenght();
            double c = edge3.GetLenght();

            if (a == b || a == c || b == c)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
