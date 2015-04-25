using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace RepoManager
{
    public class Repo
    {
        public string Name = "";
        public List<Mod> Mods = new List<Mod>();
        public ArmaServer ArmaServer = new ArmaServer();
        public TeamspeakServer TeamspeakServer = new TeamspeakServer();

        public static Repo FromFile(string file)
        {
            string repoJson = File.ReadAllText(file);
            return JsonConvert.DeserializeObject<Repo>(repoJson);
        }

        public void Save(string file)
        {
            string repoJson = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(file, repoJson);
        }
    }
}
