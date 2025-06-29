using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessson1
{
    public class Element<T>
    {
        public Element()
        {
            ListElements = new List<T>();
        }

        public List<T> ListElements { set; get; }
        public void AddToList(T add)
        {
            ListElements.Add(add);
        }
    }
}
