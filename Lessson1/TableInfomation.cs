using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lessson1
{
    internal class TableInfomation
    {
        public string Name { set; get; }

        public double Length { set; get; }

        public double Width { set; get; }

        public double AreaCalculate()
        {
            double area = Length * Width;
            return area;
        }

        public string Infomation()
        {
            string result = string.Empty;
            result += Name;
            double areaTable = AreaCalculate();
            result += $"Area= {areaTable} m2";
            return result;
        }

    }
}
