using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessson1
{
    public class Animal
    {
        public double WeightKg { get; set; }

        public int FootCount { set; get; }

        public void PrintInformation()
        {
            WeightKg = 10;
            string infomationValue = $"KL={WeightKg} kg, Foot= {FootCount}";
            Console.WriteLine(infomationValue);
            
        }
    }
}
