using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitl_1._0
{
    class Info
    {
        public Info()
        {

        }

        public string name;
        public string surname;
        public string ill;
        public string insureance;
        public int age;

        public Info(string nm, string sn, int age1, string illness, string ins)
        {
            name = nm;
            surname = sn;
            ill = illness;
            insureance = ins;
            age = age1;
        }

        public override string ToString()
        {
            return name + "     " + surname + "     " + age+ "      " + ill + "     " + insureance;
        }
    }
}
