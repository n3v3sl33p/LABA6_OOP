using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA6_OOP
{
    internal class ShapeFactory
    {
        static public Shape CreateShape(char type)
        {
            switch (type)
            {
                case 'T':
                    return new Triangle();
                case 'H':
                    return new Hexagon();
                default:
                    return null;
            }
        }
    }
}
