using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessson1
{
    public class Engineer : People
    {
        public override int Age { get;set;}

        public override int SetAge(int age)
        {
            Age = age + 1;
            return Age;
        }
    }
}
