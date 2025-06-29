using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessson1
{
    public class Wall
    {

        private double thickness;
        public double Thickness
        {
            get { return thickness; }
            set { thickness = value; }
        }


        private double height;
        public double Height
        {
            get { return height; }
            set { height = value; }
        }  

        public double Area()
        {
            return height * thickness;
        }

        public void Volume(double length,out double volume, out double area)
        {
            volume = length * height * thickness;
            area= length * thickness;
        }

        public void Area(double length,ref double area)
        {
            area  +=100;
        }

        public void AddList(List<Circle> listCircle)
        {
            Circle circle3 = new Circle();
            circle3.Name = " Circle 1";
            circle3.Radius = 10;
            listCircle.Add(circle3);
        }

    }
}
