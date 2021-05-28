using ItemPicker.Logic.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ItemPicker
{
    public class ItemPicker
    {
        private Random rng = new Random();
        private List<Item> items;
        private List<Player> players;

        public List<Player> GetPlayerItems(List<string> playerNames, int numberOfItems, bool includeEvidenceItems)
        {
            var itemReader = new ItemReader();
            items = itemReader.GetItems();
            if (!includeEvidenceItems)
            {
                items = items.Where(x => !x.EvidenceItem).ToList();
            }
            players = new List<Player>();
            foreach (string name in playerNames)
            {
                var player = new Player(name);
                while(player.Items.Count < numberOfItems)
                {
                    var item = PickRandomItem(player);
                    player.Items.Add(item);
                }
                players.Add(player);
            }
            return players;
        }

        private Item PickRandomItem(Player currentPlayer)
        {
            bool looping = true;
            int loop = 0;
            Item item = null;
            while (looping)
            {
                var index = rng.Next(0, items.Count);
                var selectedItem = items[index];
                if (CheckItemAllowed(currentPlayer, selectedItem))
                {
                    item = selectedItem;
                    looping = false;
                }
                else
                {
                    loop++;
                    if (loop > 5)
                        throw new Exception("too many loops");
                }
            }
            return item;
        }

        private bool CheckItemAllowed(Player player, Item item)
        {
            if(GetCountAmongstPlayers(item) >= item.Maximum)
            {
                return false;
            }
            if(!item.MultiplePerPerson && player.Items.Where(x => x.Name == item.Name).Count() > 0)
            {
                return false;
            }
            foreach(var incompatability in item.Incompatabilities)
            {
                var match = player.Items.Where(x => x.Name == incompatability).FirstOrDefault();
                if (match != null)
                {
                    return false;
                }
            }
            return true;            
        }

        private int GetCountAmongstPlayers(Item item)
        {
            return players.SelectMany(x => x.Items).Where(x => x.Name == item.Name).Count();
        }
    }
}
