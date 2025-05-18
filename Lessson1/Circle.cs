using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessson1
{
    public class Circle
    {
        public string Name { set; get; }

        public double Radius { set; get; }

        public static Circle operator -(Circle circle1, Circle circle2)
        {
            Circle newCircle = new Circle();
            newCircle.Name = circle1.Name + " " + circle2.Name;
            newCircle.Radius = circle1.Radius - circle2.Radius;
            return newCircle;
        }

        public static Circle operator+ (Circle circle1, Circle circle2)
        {
            Circle newCircle = new Circle();
            newCircle.Radius = circle1.Radius + circle2.Radius;
            return newCircle;
        }

    }
}
