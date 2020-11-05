using System;
using System.Collections.Generic;

namespace ItemPicker
{
    class Program
    {
        static void Main(string[] args)
        {
            var itemReader = new ItemReader();
            var items = itemReader.GetItems();



            var picker = new ItemPicker();
            var playerNames = new List<string> 
            {
                "Fluff",
                "Lumi",
                "Gris",
                "George"
            };
            var numberOfItems = 3;
            var players = picker.GetPlayerItems(playerNames, numberOfItems);
            foreach(var player in players)
            {
                Console.WriteLine(player.GetPlayerItemString());
            }
        }
    }
}
