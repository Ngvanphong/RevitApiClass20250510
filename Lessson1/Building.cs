using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessson1
{
    public class Building : IAddress, IPeopleInfomation
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public int CountPeople { get ; set ; }

        public int CountNewPeople(int count)
        {
            throw new NotImplementedException();
        }

        public void PrintInformation()
        {
            Console.WriteLine("Building infomation");
        }
    }
}
