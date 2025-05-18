using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessson1
{
    public struct Chair
    {
        public double Height { set; get; }
        public double Width { set; get; }   
        public void Save()
        {
            Height = 0; Width = 0;
        }
    }
}
