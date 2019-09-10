using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassReusing
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomList list = new RandomList();

            list.Add("edno");
            list.Add(2);
            list.Add(3);

            Console.WriteLine(list.RandomString());
        }
    }
}
