using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone3
{
    internal class Triangle
    {
        public double surfaceArea;
        public Triangle(double side1, double altitude)
        {
            //using one side and altitude to find the surface area by the formular (Area of triangle = 1/2 x base x height)
            this.surfaceArea = side1*altitude*0.5;
        }

        public Triangle(double side1, double side2, double side3)
        {
            //using three sides to find the surface area by the standard formular 
            //Area of triangle = √[s(s – a)(s – b)(s – c)],
            //where s is the semi-perimeter of the triangle, and a, b, c are lengths of the three sides of the triangle

            double s = (side1 + side2 + side3) /2;
            this.surfaceArea = Math.Sqrt(s*(s- side1) *(s- side2) *(s- side3));
        }

        public Triangle (double side1, double side2, int angle)
        {
            //using two sides and the angle between them to find the surface area by the standard formular 
            //Area of triangle = a x b x Sin(y/2)
            //Where a, b and y are two two sides and the angle between them respectively
            //and angle must be passed in as an integer value

            this.surfaceArea = side1 * side2 * Math.Sin(angle / 2);

        }

    }
}
