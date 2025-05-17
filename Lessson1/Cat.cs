using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessson1
{
    public class Cat: Animal
    {
        public string Name { set; get; }
        public string Color { set; get; }

        public void CatInformation()
        {
            string resultValue = $"Name : {Name} , Color {Color}, \n Weight {WeightKg} Foot {FootCount}";
            Console.WriteLine(resultValue);
        }
    }
}
