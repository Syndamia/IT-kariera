using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectNumbers {
    class Program {
        static void Main(string[] args) { //Main method is predetermined by the task

            int capacity = int.Parse(Console.ReadLine());

            Dictionary<String, CapacityList> players = new Dictionary<string, CapacityList>();

            string command = "";
            do {
                command = Console.ReadLine();
                string[] commands = command.Split(' ').ToArray();
                switch(commands[0]) {
                    case "Dice":
                        string player = commands[1];
                        int value1 = int.Parse(commands[2]);
                        int value2 = int.Parse(commands[3]);
                        if(players.ContainsKey(player)) {
                            players[player].Add(new Pair(value1, value2));
                        }
                        else {
                            players.Add(player, new CapacityList(capacity));
                            players[player].Add(new Pair(value1, value2));
                        }
                        break;
                    case "CurrentPairSum":
                        string playerName = commands[1];
                        if(players.ContainsKey(playerName)) {
                            Console.WriteLine(players[playerName].Sum());
                        }
                        break;
                    case "CurrentStanding":
                        players = players.OrderBy(element => element.Value.Sum().Difference())
                            .ToDictionary(element => element.Key, element => element.Value);
                        foreach(var item in players) {
                            Console.WriteLine(item.Key + " - " + item.Value.Sum());
                        }
                        break;
                    case "CurrentState":
                        string playerNameState = commands[1];
                        if(players.ContainsKey(playerNameState)) {
                            players[playerNameState].PrintCurrentState();
                        }

                        break;
                    case "Winner":
                        players = players.OrderBy(element => element.Value.Sum().Difference())
                            .ThenBy(element => element.Key)
                            .ToDictionary(element => element.Key, element => element.Value);
                        Console.WriteLine("{0} wins the game!", players.First().Key);
                        break;

                }
            } while(command != "End");
        }

    }
}
