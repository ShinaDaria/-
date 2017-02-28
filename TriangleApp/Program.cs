using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleApp
{
    class Program
    {
        static void FormArray(Triangle[] triangles, int n)
        {
            
            for (int i = 0; i < n; i++)
            {
                Console.Write("X1 = ");
                int x1 = int.Parse(Console.ReadLine());

                Console.Write("Y1 = ");
                int y1 = int.Parse(Console.ReadLine());

                Point p1 = new Point(x1, y1);

                Console.Write("X2 = ");
                int x2 = int.Parse(Console.ReadLine());

                Console.Write("Y2 = ");
                int y2 = int.Parse(Console.ReadLine());

                Point p2 = new Point(x2, y2);

                Console.Write("X3 = ");
                int x3 = int.Parse(Console.ReadLine());

                Console.Write("Y3 = ");
                int y3 = int.Parse(Console.ReadLine());

                Point p3 = new Point(x3, y3);

                Triangle tr = new Triangle(p1, p2, p3);

                triangles[i] = tr;
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Кол-во треугольников = ");
            int n = int.Parse(Console.ReadLine());

            Triangle[] triangles = new Triangle[n];
            FormArray(triangles, n);

            double sum_perimetr = 0;
            int count_right = 0;

            double sum_area = 0;
            int count_isosceles = 0;

            for (int i = 0; i < n; i++)
            {
                if (triangles[i].IsRight())
                {
                    count_right++;
                    sum_perimetr += triangles[i].GetPerimetr();
               }

                if (triangles[i].IsIsosceles())
                {
                    count_isosceles++;
                    sum_area += triangles[i].GetSquare();
                }
                else
                {
                    count_right = 1;
                    count_isosceles = 1;
                } 
           }
                double sred_perimetr = sum_perimetr / count_right;
                double sred_area = sum_area / count_isosceles;
            
               
            
                Console.WriteLine("Средний периметр всех прямоугольных треугольников = {0}", sred_perimetr);
                Console.WriteLine("Cредняя площадь всех равнобедренных треугольников = {0}", sred_area);
            
            Console.ReadKey();
       }
    }
}
