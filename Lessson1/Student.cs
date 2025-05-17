using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessson1
{
    public class Student : People
    {
        public string Class { set; get; }
        public override int Age { get; set; }

        public DiemSo DiemSoHS { set; get; }

        public override int SetAge(int age)
        {
            Age = age;
            return Age;
        }



        
    }
    
}
