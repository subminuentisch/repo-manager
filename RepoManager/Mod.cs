using System;
using System.Collections.Generic;
using System.Text;

namespace RepoManager
{
    public class Mod
    {
        public string Name = "";
        public bool Optional = false;
        public List<ModFile> Files = new List<ModFile>();
    }
}
