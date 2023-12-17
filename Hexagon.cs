using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA6_OOP
{
    internal class Hexagon : Shape
    {
        public Hexagon()
        {
            points = new Point[6];
            ID = "Hexagon";
        }

        public override double getSquare()
        {
            Point center = new Point();
            center = getCenter();
            double s1, s2, s3, s4, s5, s6;
            s1 = Math.Abs(points[0].x * (points[1].y - center.y) + points[1].x * (center.y - points[0].y) + center.x * (points[0].y - points[1].y)) / 2.0;
            s2 = Math.Abs(points[1].x * (points[2].y - center.y) + points[2].x * (center.y - points[1].y) + center.x * (points[1].y - points[2].y)) / 2.0;
            s3 = Math.Abs(points[2].x * (points[3].y - center.y) + points[3].x * (center.y - points[2].y) + center.x * (points[2].y - points[3].y)) / 2.0;
            s4 = Math.Abs(points[3].x * (points[4].y - center.y) + points[4].x * (center.y - points[3].y) + center.x * (points[3].y - points[4].y)) / 2.0;
            s5 = Math.Abs(points[4].x * (points[5].y - center.y) + points[5].x * (center.y - points[4].y) + center.x * (points[4].y - points[5].y)) / 2.0;
            s6 = Math.Abs(points[0].x * (points[5].y - center.y) + points[5].x * (center.y - points[0].y) + center.x * (points[0].y - points[5].y)) / 2.0;
            return s1 + s2 + s3 + s4 + s5 + s6;
        }

        public override Point getCenter()
        {
            Point res = new Point();
            res.x = (points[1].x - points[0].x) / 2 + points[0].x;
            res.y = (points[0].y - points[4].y) / 2 + points[4].y;
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
            points[3].x += x;
            points[3].y += y;
            points[4].x += x;
            points[4].y += y;
            points[5].x += x;
            points[5].y += y;
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
