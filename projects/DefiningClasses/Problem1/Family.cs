using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Family
    {
        private List<Person> list;

        public Family()
        {
            list = new List<Person>();
        }

        public List<Person> List
        {
            get => list;
            set => list = value;
        }

        public void Add(Person person)
        {
            list.Add(person);
        }
        public string Print()
        {
            list = list.OrderBy(x => x.Name).ToList();
            StringBuilder sb = new StringBuilder();

            foreach(var person in list)
            {
                if(person.Age > 30)
                {
                    sb.Append($"{person} \n");
                }
            }

            return sb.ToString();
        }
    }
}
