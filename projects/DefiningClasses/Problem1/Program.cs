using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Family family = new Family();
            int personsToAdd = int.Parse(Console.ReadLine());

            for(int i = 0 ; i < personsToAdd ; i++)
            {

                string[] comandArgs = Console.ReadLine().Split(' ');
                string name = comandArgs[0];
                int age = int.Parse(comandArgs[1]);

                Person person = new Person(age, name);

                family.Add(person);
            }
            string toPrint = family.Print();
            Console.WriteLine(toPrint);
        }
    }
}
