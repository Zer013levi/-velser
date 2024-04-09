using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace begynder
{
    public class playere
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public playere(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
