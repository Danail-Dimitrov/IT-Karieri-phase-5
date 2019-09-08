using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Person
    {
        private int age;
        private string name;

        public int Age
        {
            get => age;
            set => age = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }

        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }
        public Person()
        {
        }

        public override string ToString()
        {
            return $"{Name} - {Age}";
        }
    }
}
