using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Animal
    {
        private string name;
        private string favouriteFood;

        public Animal(string name, string favouriteFood)
        {
            this.Name = name;
            this.FavouriteFood = favouriteFood;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }
        public string FavouriteFood
        {
            get => favouriteFood;
            set => favouriteFood = value;
        }

        public virtual string ExplainMyself()
        {
            return "Animal";
        }
    }
}
