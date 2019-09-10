using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassReusing
{
    class StackOfStrings<T>
    {
        private List<T> data;

        public StackOfStrings()
        {
            data = new List<T>();
        }
        public void Push(T item)
        {
            data.Add(item);
        }
        public T Pop()
        {
            var toRturn = data[data.Count - 1];
            data.RemoveAt(data.Count - 1);
            return toRturn;
        }

        public T Peek()
        {
            return data[data.Count - 1];
        }
        public bool IsEmpty()
        {
            if(data.Count <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
