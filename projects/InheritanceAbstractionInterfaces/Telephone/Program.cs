using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephone
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ').ToArray();
            string[] urls = Console.ReadLine().Split(' ').ToArray();

            Telephone phone = new Telephone(numbers, urls);

            Console.WriteLine(phone.Call());
            Console.WriteLine(phone.Browse());
        }
    }
}
