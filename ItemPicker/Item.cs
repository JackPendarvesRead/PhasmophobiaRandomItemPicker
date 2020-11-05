using System;
using System.Collections.Generic;
using System.Text;

namespace ItemPicker
{
    public class Item
    {
        public string Name { get; set; }
        public int Maximum { get; set; }
        public bool MultiplePerPerson { get; set; }
        public List<string> Incompatabilities { get; set; }
    }
}
