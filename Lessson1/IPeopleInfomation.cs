using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessson1
{
    public interface IPeopleInfomation
    {
        int CountPeople { set; get; }

        int CountNewPeople(int count);

    }
}
