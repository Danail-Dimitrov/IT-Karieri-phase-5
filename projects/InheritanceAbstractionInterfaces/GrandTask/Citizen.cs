using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandTask
{
    abstract class Citizen
    {
        private string id;

        protected Citizen(string id)
        {
            Id = id;
        }

        public string Id
        {
            get => id;
            set => id = value;
        }
    }
}
