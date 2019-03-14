using System;
using System.Collections.Generic;
using System.Linq;

namespace Military_Elite
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input;
            List<Soldier> list = new List<Soldier>();




            while ((input = Console.ReadLine()) != "End")

            {
                try
                {
                    string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string type = tokens[0];

                    int id = int.Parse(tokens[1]);
                    if (list.Any(x => x.Id == id))
                    { continue; }
                    string firstName = tokens[2];
                    string lastName = tokens[3];
                    decimal salary;
                    string corps;
                    switch (type)
                    {
                        case "Private":
                            salary = decimal.Parse(tokens[4]);
                            var currPrivate = new Private(firstName, lastName, id, salary);
                            list.Add(currPrivate);
                            break;


                        case "Spy":
                            int codeNumber = int.Parse(tokens[4]);
                            var currSpy = new Spy(firstName, lastName, id, codeNumber);
                            list.Add(currSpy);
                            break;


                        case "LieutenantGeneral":
                            salary = decimal.Parse(tokens[4]);
                            int[] privateIds = input.Split().Skip(5).Select(int.Parse).ToArray();

                            List<Private> privatesToAdd = new List<Private>();
                            foreach (var privateId in privateIds)
                            {
                                Private currentPrivate = (Private)list.Where(x => x.Id == privateId).FirstOrDefault();
                                privatesToAdd.Add(currentPrivate);
                            }
                            var currLGeneral = new LieutenantGeneral(firstName, lastName, id, salary, privatesToAdd);
                            list.Add(currLGeneral);
                            break;


                        case "Engineer":
                            salary = decimal.Parse(tokens[4]);
                            corps = tokens[5];
                            string[] repairsArr = input.Split().Skip(6).ToArray();
                            List<Repair> repairsToAdd = new List<Repair>();

                            for (int i = 0; i < repairsArr.Length - 1; i += 2)
                            {
                                string partName = repairsArr[i];
                                int hoursWorked = int.Parse(repairsArr[i + 1]);
                                var repair = new Repair(partName, hoursWorked);
                                repairsToAdd.Add(repair);
                            }
                            var currEngineer = new Engineer(firstName, lastName, id, salary, corps, repairsToAdd);
                            list.Add(currEngineer);
                            break;


                        case "Commando":
                            salary = decimal.Parse(tokens[4]);
                            corps = tokens[5];

                            string[] missionsArr = input.Split().Skip(6).ToArray();
                            var missionsToAdd = new List<Mission>();
                            for (int i = 0; i < missionsArr.Length - 1; i += 2)
                            {
                                string codeName = missionsArr[i];
                                string state = missionsArr[i + 1];
                                if (state != "Finished" && state != "inProgress")
                                    continue;
                                var mission = new Mission(codeName, state);
                                missionsToAdd.Add(mission);
                            }
                            var currCommando = new Commando(firstName, lastName, id, salary, corps, missionsToAdd);
                            list.Add(currCommando);
                            break;


                        default:
                            Console.WriteLine("Invalid Type of Soldier!");
                            break;
                    }
                }

                catch (Exception)
                {
                    continue;
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
