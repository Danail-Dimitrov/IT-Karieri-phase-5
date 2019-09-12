using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandTask
{
    class Human : Citizen, IBirthable, IBuyer
    {
        private string name;
        private int age;
        private string birthdate;
        private int food;

        public Human(string id, string name, int age, string birthdate) : base(id)
        {
            Name = name;
            Age = age;
            Birthdate = birthdate;
            Food = 0;
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
        public string Birthdate
        {
            get => birthdate;
            set => birthdate = value;
        }
        public int Food
        {
            get => food;
            set => food = value;
        }

        public void BuyFood()
        {
            Food += 10;
        }
    }
}
