using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassReusing
{
    class RandomList : ArrayList
    {
        public object RandomString()
        {
            Random random = new Random();
            int randomInt = random.Next(0, this.Count);

            object toReturn = base[randomInt];
            this.RemoveAt(randomInt);

            return toReturn;
        }
    }
}
