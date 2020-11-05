using System;
using System.Collections.Generic;

namespace ItemPicker
{
    class Program
    {
        static void Main(string[] args)
        {
            var picker = new ItemPicker();
            var playerNames = new List<string> 
            {
                "Fluff",
                "Lumi"
            };
            var numberOfItems = 4;
            var players = picker.GetPlayerItems(playerNames, numberOfItems, false);
            foreach(var player in players)
            {
                Console.WriteLine(player.GetPlayerItemString());
            }
        }
    }
}
