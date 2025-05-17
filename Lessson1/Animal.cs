using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessson1
{
    public class Animal
    {
        public static int CountInstance=0;
        public Animal()
        {
            
        }
        public Animal(double weightKg, int footCount)
        {
            WeightKg= weightKg;
            FootCount= footCount;
        }
        ~Animal()
        {

        }
        public double WeightKg { get; set; }

        public int FootCount { set; get; }

        public static void PrintInformation()
        {
            double WeightKg = 30;
            string infomationValue = $"KL={WeightKg} kg, Foot= {CountInstance}";
            Console.WriteLine(infomationValue);
            string information = string.Empty;
            information += "This ssss";
        }

        public double Add(double a, double b, double c)
        {
            double result = a + b + c;
            return result;
        }

        public virtual double Subtract(double a, double b)
        {
            return  a - b;
        }
    }
}
