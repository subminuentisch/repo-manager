using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace RepoManager
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Resolve embedded DLLs
            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {
                String resourceName = "RepoManager." + new AssemblyName(args.Name).Name + ".dll";
                if (resourceName != "RepoManager.Newtonsoft.Json.dll") return Assembly.GetCallingAssembly();
                
                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
                {
                    Byte[] assemblyData = new Byte[stream.Length];
                    stream.Read(assemblyData, 0, assemblyData.Length);

                    return Assembly.Load(assemblyData);
                }
            };

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
