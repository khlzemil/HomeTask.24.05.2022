using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask._24._05._2022
{
    internal class Person
    {
        public string Name;
        public string Surname;
        public int Age;
        public bool IsAdult;

        public Person()
        {
            if(Age > 18)
                IsAdult = true;
            else
                IsAdult = false;

        }

    }
}
