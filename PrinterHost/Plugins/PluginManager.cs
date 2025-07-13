using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterHost.Plugins
{
    internal class PluginManager
    {
        public void LoadPlugins()
        {
            // Logic to load plugins
            Console.WriteLine("Plugin manager ready.");
        }

        internal void PreLoadPlugin(string pluginPath)
        {
            Console.WriteLine("Prepating to load plugin from: " + pluginPath);
        }
    }
}
