using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commandArgs = Console.ReadLine().Split(' ').ToArray();

            List<IBirthable> list = new List<IBirthable>();

            while(commandArgs[0] != "End")
            {
                switch(commandArgs[0])
                {
                    case "Citizen":
                        Human human = new Human(commandArgs[3], commandArgs[1], int.Parse(commandArgs[2]), commandArgs[4]);

                        list.Add(human);
                        break;
                    case "Robot":
                        Robot robot = new Robot(commandArgs[2], commandArgs[1]);

                        //list.Add(robot);
                        break;
                    case "Pet":
                        Pet pet = new Pet(commandArgs[1], commandArgs[2]);

                        list.Add(pet);
                        break;
                }

                commandArgs = Console.ReadLine().Split(' ').ToArray();
            }

            string year = Console.ReadLine();

            List<IBirthable> bornInYear = new List<IBirthable>();

            foreach(var birthable in list)
            {
                if(birthable.Birthdate.EndsWith(year))
                {
                    bornInYear.Add(birthable);
                }
            }

            foreach(var birthable in bornInYear)
            {
                Console.WriteLine(birthable.Birthdate);
            }

            //string fakeIds = Console.ReadLine();

            //List<Citizen> arested = new List<Citizen>();

            //foreach(var citizen in list)
            //{
            //    if(citizen.Id.EndsWith(fakeIds))
            //    {
            //        arested.Add(citizen);
            //    }
            //}

            //foreach(var citizen in arested)
            //{
            //    Console.WriteLine(citizen.Id);
            //}
        }
    }
}
