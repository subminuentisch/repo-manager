using System;
using System.Collections.Generic;
using System.Text;

namespace RepoManager
{
    public class ModFileInfo
    {
        public string Checksum = "";
        public DateTime LastModified = DateTime.MinValue;

        public ModFileInfo() { }

        public ModFileInfo(string checksum, DateTime lastModified)
        {
            this.Checksum = checksum;
            this.LastModified = lastModified;
        }
    }
}
