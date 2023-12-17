using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA6_OOP
{
    internal class Triangle : Shape
    {
        public Triangle()
        {
            points = new Point[3];
            ID = "Triangle";
        }
        public override double getSquare()
        {
            return Math.Abs(points[0].x * (points[1].y - points[2].y) + points[1].x * (points[2].y - points[0].y) + points[2].x * (points[0].y - points[1].y)) / 2.0;
        }
        public override Point getCenter()
        {
            Point res = new Point();
            res.x = (points[0].x + points[1].x + points[2].x) / 3;
            res.y = (points[0].y + points[1].y + points[2].y) / 3;
            return res;
        }
        public override void move(int x, int y)
        {
            points[0].x += x;
            points[0].y += y;
            points[1].x += x;
            points[1].y += y;
            points[2].x += x;
            points[2].y += y;
        }
        public override void rotate(double angel)
        {
            Point center = getCenter();

            for (int i = 0; i < points.Length; i++)
            {
                double x = points[i].x - center.x;
                double y = points[i].y - center.y;
                double xNew = x * Math.Cos(angel) - y * Math.Sin(angel);
                double yNew = x * Math.Sin(angel) + y * Math.Cos(angel);
                points[i].x = Convert.ToInt32(xNew) + center.x;
                points[i].y = Convert.ToInt32(yNew) + center.y;
            }
        }
    }
}
