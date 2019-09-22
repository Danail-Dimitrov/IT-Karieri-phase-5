using System;

namespace OverrideAndOverload
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(MathOperations.Add(2, 3));
            Console.WriteLine(MathOperations.Add(2.2, 3.3, 5.5));
            Console.WriteLine(MathOperations.Add(2.2m, 3.3m, 4.4m));
        }
    }
}
