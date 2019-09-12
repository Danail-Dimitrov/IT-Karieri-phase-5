using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandTask
{
    class Rebel : IBuyer
    {
        private string name;
        private int age;
        private string group;
        private int food;

        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
            Food = 0;
        }

        public int Food
        {
            get => food;
            set => food = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public int Age
        {
            get => age;
            set => age = value;
        }
        public string Group
        {
            get => group;
            set => group = value;
        }

        public void BuyFood()
        {
            Food += 5;
        }
    }
}
