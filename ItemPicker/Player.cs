using System;
using System.Collections.Generic;
using System.Text;

namespace ItemPicker
{
    public class Player
    {
        public Player(string name)
        {
            Items = new List<ItemEnum>();
            Name = name;
        }

        public string Name { get; set; }
        public List<ItemEnum> Items { get; set; }

        public string GetPlayerItemString()
        {
            var sb = new StringBuilder();
            sb.Append($"{Name}: ");
            foreach(var item in Items)
            {
                sb.Append(item + " ");
            }
            return sb.ToString();
        }
    }
}
