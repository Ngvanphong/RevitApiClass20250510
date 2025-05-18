using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessson1
{
    public interface IAddress
    {
        string Street { set; get; }
        string City { set; get; }
        string Phone { set; get; }

        void PrintInformation();


    }
}
