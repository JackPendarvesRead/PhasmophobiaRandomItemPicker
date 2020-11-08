using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ItemPicker
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
            foreach(var item in Items.OrderBy(x => x.Name)
            {
                sb.Append(item.Name + ", ");
            }
            return sb.ToString();
        }
    }
}
