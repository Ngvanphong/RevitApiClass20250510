using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessson1
{
    public abstract class People
    {
        public abstract int Age { get; set; }
        public void Infomation(string name, int cccd, int age)
        {
            Console.WriteLine($"{name} {cccd} {age}");
        }

        public abstract int SetAge(int age);
    }
}
