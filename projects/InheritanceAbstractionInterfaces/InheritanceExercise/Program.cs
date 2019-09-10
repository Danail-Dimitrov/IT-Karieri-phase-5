using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Puppy puppy = new Puppy();
            Console.WriteLine(puppy.Eat());
            Console.WriteLine(puppy.Bark());
            Console.WriteLine(puppy.Weep());

            Cat cat = new Cat();
            Console.WriteLine(cat.Eat());
            Console.WriteLine(cat.Meow());
        }
    }
}
