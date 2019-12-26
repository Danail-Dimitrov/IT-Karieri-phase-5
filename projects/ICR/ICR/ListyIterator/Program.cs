using System;
using System.Linq;

namespace ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commandArgs = Console.ReadLine().Split(' ').ToArray();
            ListIterator<string> listI = new ListIterator<string>();
            bool toPrint;
            string toPrintStr;

            while(commandArgs[0] != "End")
            {
                switch(commandArgs[0])
                {
                    case "Create":
                        string[] withoutFirst = RemoveFirst(commandArgs);
                        listI.Create(withoutFirst);
                        break;
                    case "Move":
                        toPrint = listI.Move();
                        Print(toPrint);
                        break;
                    case "HasNext":
                        toPrint = listI.HasNext();
                        Print(toPrint);
                        break;
                    case "Print":
                        toPrintStr = listI.Print();
                        Print(toPrintStr);
                        break;
                    default:
                        break;
                }

                commandArgs = Console.ReadLine().Split(' ').ToArray();
            }
        }

        private static string[] RemoveFirst(string[] commandArgs)
        {
            commandArgs = commandArgs.Reverse().ToArray();

            int lenght = commandArgs.Length;
            string[] withoutFirst = new string[lenght - 1];

            for(int i = 0; i < lenght - 1; i++)
            {
                withoutFirst[i] = commandArgs[i];
            }
            withoutFirst = withoutFirst.Reverse().ToArray();

            return withoutFirst;
        }

        private static void Print(bool toPrint)
        {
            Console.WriteLine(toPrint);
        }
        private static void Print(string toPrint)
        {
            Console.WriteLine(toPrint);
        }

    }
}
