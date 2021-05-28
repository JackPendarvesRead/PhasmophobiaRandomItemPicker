using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ItemPickerWithClipboard.Infrastructure
{
    public class Player
    {
        public Player(string name)
        {
            Items = new List<Item>();
            Name = name;
        }

        public string Name { get; set; }
        public List<Item> Items { get; set; }

        public string GetPlayerItemString()
        {
            var sb = new StringBuilder();
            sb.Append($"{Name}: ");
            var orderedItems = Items.OrderBy(x => x.Name).ToList();
            for(var i = 0; i < orderedItems.Count; ++i)
            {
                sb.Append(orderedItems[i].Name);
                sb.Append(i < orderedItems.Count - 1 ? ", " : ".");
            }
            return sb.ToString();
        }
    }
}
