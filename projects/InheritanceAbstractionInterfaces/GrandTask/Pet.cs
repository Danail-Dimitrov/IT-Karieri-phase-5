using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandTask
{
    class Pet : IBirthable
    {
        public string Name
        {
            get;
            set;
        }
        public string Birthdate
        {
            get;
            set; 
        }

        public Pet(string name, string birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }
    }
}
