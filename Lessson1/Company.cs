using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessson1
{
    public class Company : IAddress, IPeopleInfomation
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public int CountPeople { get; set; }

        public int CountNewPeople(int count)
        {
            return 1;
        }

        public void CityInfo()
        {
            Console.WriteLine(City);
        }

        public void CityInfo(string city)
        {
            Console.WriteLine(city);
        }

        public int CityInfo(int count)
        {
            return 1;
        }

        public void PrintInformation()
        {
            Console.WriteLine("Company");
        }
    }
}
