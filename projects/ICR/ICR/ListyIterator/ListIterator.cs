using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListyIterator
{
    class ListIterator<T>
    {
        private int index;
        private List<T> list;

        public ListIterator()
        {           
            this.index = 0;
        }

        public void Create(T[] elements)
        {
            list = elements.ToList();
        }

        public bool Move()
        {
            index++;
            return index <= list.Count - 1;
        }

        public bool HasNext()
        {
            return index < list.Count - 1;
        }

        public string Print()
        {

            if(list.Count <= 0)
            {
                return "Invalid Operation";
            }

            return list[index].ToString();
        }

    }
}
