using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA6_OOP
{
    abstract class Shape
    {
        protected Point[] points = null;
        protected string ID;

        //Подсчет площади 
        public abstract double getSquare();
        //центр тяжести
        public abstract Point getCenter();
        //передвижение
        public abstract void move(int x, int y);
        //поворот
        public abstract void rotate(double angel);
        public int getCountPoints()
        {
            return points.Length;
        }
        public void initPointsByIndex(char o,int index,int value)
        {
            if (points[index] == null)
            {
                points[index] = new Point();    
            }
            if (o == 'x')
            {
                
                points[index].x = value;
            }
            else if (o == 'y')
            {
                
                points[index].y = value;
            }
        }


        //метод инициализации
        /*public void initPoints()
        {
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point();
                points[i].x = Convert.ToInt32(Console.ReadLine());
                points[i].y = Convert.ToInt32(Console.ReadLine());

            }
            if (getCountPoints() == 3)
            {
                if ((points[0].x == points[1].x && points[0].x == points[2].x) || (points[0].y == points[1].y && points[0].y == points[2].y))
                {
                    throw new Exception("Треугольника не существует");
                }
            }
            else if (getCountPoints() == 6)
            {
                double a, b, c, d, e, f;
                a = Math.Sqrt(Math.Pow(points[1].x - points[0].x, 2) + Math.Pow(points[1].y - points[0].y, 2));
                b = Math.Sqrt(Math.Pow(points[2].x - points[1].x, 2) + Math.Pow(points[2].y - points[1].y, 2));
                c = Math.Sqrt(Math.Pow(points[3].x - points[2].x, 2) + Math.Pow(points[3].y - points[2].y, 2));
                d = Math.Sqrt(Math.Pow(points[4].x - points[3].x, 2) + Math.Pow(points[4].y - points[3].y, 2));
                e = Math.Sqrt(Math.Pow(points[5].x - points[4].x, 2) + Math.Pow(points[5].y - points[4].y, 2));
                f = Math.Sqrt(Math.Pow(points[5].x - points[0].x, 2) + Math.Pow(points[5].y - points[0].y, 2));
                if (!(a == b && a == c && a == d && a == e && a == f))
                {
                    throw new Exception("Шестиугольник не праивльный");
                }
            }
        }*/
        //свойства
        public Point[] Points
        {
            get { return points; }
        }
        
        public string getId
        {
            get { return ID; }
        }
    }
}
