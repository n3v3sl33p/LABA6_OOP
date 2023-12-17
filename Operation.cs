using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA6_OOP
{
    internal class Operation
    {
        //сравнение по площади 
        static public int compare(Shape firstShape, Shape secondShape)
        {
            return Convert.ToInt32(firstShape.getSquare() - secondShape.getSquare());
        }
        //включение
        static public bool isInclude(Shape firstShape, Shape secondShape)
        {
            for (int i = 0; i < secondShape.getCountPoints(); i++)
            {
                if (isPointIncludeShape(firstShape,  secondShape.Points[i]) == false)
                {
                    return false;
                }
            }
            return true;
        }
        //пересечение
        static public bool isIntersected( Shape firstShape, Shape secondShape)
        {
            double r1 = 0, r2 = 0, distanceCenter = 0;
            Point firstCenter = firstShape.getCenter();
            Point secondCenter = secondShape.getCenter();
            r1 = Math.Sqrt(Math.Pow(firstCenter.x - firstShape.Points[0].x, 2) + Math.Pow(firstCenter.y - firstShape.Points[0].x, 2));
            r2 = Math.Sqrt(Math.Pow(secondCenter.x - secondShape.Points[0].x, 2) + Math.Pow(secondCenter.y - secondShape.Points[0].x, 2));
            distanceCenter = Math.Sqrt(Math.Pow(secondCenter.x - firstCenter.x, 2) + Math.Pow(secondCenter.y - firstCenter.y, 2));
            if (distanceCenter <= r1 + r2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static private int pointPos(Point A, Point B, Point C)
        {
            return (A.x - C.x) * (B.y - A.y) - (B.x - A.x) * (A.y - C.y);
        }
        static private bool isPointIncludeShape(Shape shape, Point C)
        {
            for (int i = 0; i < shape.getCountPoints() - 1; i++)
            {
                if (pointPos(shape.Points[i], shape.Points[i + 1], C) < 0)
                {

                }
                else
                {
                    return false;
                }
            }
            if (pointPos( shape.Points[shape.getCountPoints() - 1], shape.Points[0], C) < 0)
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
