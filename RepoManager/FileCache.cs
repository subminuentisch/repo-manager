using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RepoManager
{
    public static class FileCache
    {
        public static Dictionary<string, ModFileInfo> Files = new Dictionary<string, ModFileInfo>();
        static string CACHE_PATH = ".c&p/cache.json";

        static FileCache()
        {
            if (File.Exists(CACHE_PATH))
                JsonConvert.PopulateObject(File.ReadAllText(CACHE_PATH), Files);
        }

        public static void Save()
        {
            File.WriteAllText(CACHE_PATH, JsonConvert.SerializeObject(Files, Formatting.Indented));
        }
    }
}
