using System;
using System.Collections.Generic;

namespace ItemPicker
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var picker = new ItemPicker();
                var playerNames = new List<string>
                {
                    "Fluff",
                    "Lumi",
                    "Griswoald"
                };
                var numberOfItems = 4;
                var players = picker.GetPlayerItems(playerNames, numberOfItems, true);
                foreach (var player in players)
                {
                    Console.WriteLine(player.GetPlayerItemString());
                }
                Console.WriteLine();
                Console.ReadLine();                
            }
            
        }
    }
}
