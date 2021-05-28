using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ItemPickerWithClipboard
{
    public class AppSettings
    {
        public List<string> PlayerNames { get; set; }
        public bool IncludeEvidenceItems { get; set; }
        public int NumberOfItemsPerPlayer { get; set; }
    }

    public static class AppSettingsReader
    {
        public static AppSettings GetAppSettings()
        {
            var appSettingsPath = Path.Combine(Directory.GetCurrentDirectory(), "AppSettings.json"); 
            using (var sr = new StreamReader(new FileStream(appSettingsPath, FileMode.Open, FileAccess.Read, FileShare.Delete)))
            {
                var ser = new JsonSerializer();
                var x = ser.Deserialize(sr, typeof(AppSettings));
                return (AppSettings)x;
            };
        }
    }
}
