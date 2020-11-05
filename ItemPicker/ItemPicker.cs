using System;
using System.Collections.Generic;
using System.Text;

namespace ItemPicker
{
    public class ItemPicker
    {
        private Random rng = new Random();

        public List<Player> GetPlayerItems(List<string> playerNames, int numberOfItems)
        {
            var players = new List<Player>();
            foreach(string name in playerNames)
            {
                var player = new Player(name);
                while(player.Items.Count < numberOfItems)
                {
                    var item = PickRandomItem();

                }
                players.Add(player);
            }
            return players;
        }

        public ItemEnum PickRandomItem()
        {
            var selection = rng.Next(0, Enum.GetNames(typeof(ItemEnum)).Length);
            return (ItemEnum)selection;
        }
    }
}
