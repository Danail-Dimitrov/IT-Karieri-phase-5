using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandTask
{
    class Robot : Citizen
    {
        private string model;

        public Robot(string id, string model) : base(id)
        {
            this.Model = model;
        }

        public string Model
        {
            get => model;
            set => model = value;
        }
    }
}
