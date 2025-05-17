using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessson1
{
    public class Dog : Animal
    {
        public string Name { get; set; }    
        public string DogColor { set; get; }

        public override double Subtract(double a, double b)
        {
            double result= base.Subtract(a, b);
            return -result;
        }
    }
}
