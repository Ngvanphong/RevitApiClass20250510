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

    }
}
