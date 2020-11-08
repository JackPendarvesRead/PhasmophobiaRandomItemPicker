using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace ItemPicker
{
    public class ItemReader
    {
        public List<Item> GetItems()
        {
            var jsonPath = Path.Combine(Directory.GetCurrentDirectory(), "ItemList.json");
            using var sr = new StreamReader(new FileStream(jsonPath, FileMode.Open, FileAccess.Read, FileShare.Delete));
            return JsonSerializer.Deserialize<List<Item>>(sr.ReadToEnd());
        }
    }
}
