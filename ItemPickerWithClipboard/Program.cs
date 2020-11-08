using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ItemPickerWithClipboard
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            while (true)
            {
                var picker = new ItemPicker();
                var playerNames = new List<string>
                {
                    "Fluff",
                    "Lumi",
                    "Griswoald"
                };
                var numberOfItems = 4;
                var players = picker.GetPlayerItems(playerNames, numberOfItems, true);
                var sb = new StringBuilder();
                foreach (var player in players)
                {
                    var s = player.GetPlayerItemString();
                    Console.WriteLine(s);
                    sb.AppendLine(s);
                }
                Clipboard.SetText(sb.ToString());
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
