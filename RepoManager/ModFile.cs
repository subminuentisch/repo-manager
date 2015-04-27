using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace RepoManager
{
    public class ModFile
    {
        public string Path = "";
        public string Checksum = "";
        public long Size = 0;

        public ModFile() {}
        
        public ModFile(string path, string checksum = null)
        {
            Path = path.Substring(path.IndexOf("\\") + 1).Replace("\\", "/");
            Size = new FileInfo(path).Length;

            if (checksum == null)
            {
                using (MD5 md5 = MD5.Create())
                {
                    using (FileStream stream = File.OpenRead(path))
                    {
                        byte[] hashRaw = md5.ComputeHash(stream);
                        Checksum = BitConverter.ToString(hashRaw).Replace("-", "").ToLower();
                        Size = stream.Length;
                    }
                }
            }
        }
    }
}
