using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace ItemPickerWithClipboard
{
    public class ItemReader
    {
        public List<Item> GetItems()
        {
            var jsonPath = Path.Combine(Directory.GetCurrentDirectory(), "ItemList.json");
            using (var sr = new StreamReader(new FileStream(jsonPath, FileMode.Open, FileAccess.Read, FileShare.Delete)))
            {
                var ser = new JsonSerializer();
                var x = ser.Deserialize(sr, typeof(List<Item>));
                return (List<Item>)x;
            };
        }
    }
}
