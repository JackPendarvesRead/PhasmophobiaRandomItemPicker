using ItemPickerWithClipboard.Logic;
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
            Console.WriteLine("Welcome to Phasmophobia random item selector!");
            Console.WriteLine("To change player names and other settings please edit values in AppSettings.json file");
            Console.WriteLine("Have fun!");
            Console.WriteLine("(note: this is a thrown together project just for a bit of fun. There may be bugs, please feel free to tell me if you find any)");
            Console.WriteLine();
            while (true)
            {               
                var settings = AppSettingsReader.GetAppSettings();
                var picker = new ItemPicker();
                var players = picker.GetPlayerItems(settings.PlayerNames, settings.NumberOfItemsPerPlayer, settings.IncludeEvidenceItems);
                var sb = new StringBuilder();
                foreach (var player in players)
                {
                    var s = player.GetPlayerItemString();
                    Console.WriteLine(s);
                    sb.AppendLine(s);
                }
                Clipboard.SetText(sb.ToString());
                Console.WriteLine();
                Console.WriteLine("Items copied successfully to clipboard!");
                Console.WriteLine("Press 'Enter' to roll items again or close window to end program.");
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
