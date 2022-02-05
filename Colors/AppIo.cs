using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Colors
{
    internal static class AppIo
    {
        public static string ExePath
        {
            get
            {
                string exepath = Assembly.GetEntryAssembly().Location;

                return exepath.Substring(0, exepath.LastIndexOf(@"\"));
            }
        }

        public static string OemPath => string.Format(@"{0}\{1}", ExePath, Properties.Settings.Default.OemPath);
        public static string RootPath => string.Format(@"{0}\{1}", ExePath, Properties.Settings.Default.RootPath);
        public static string ConfigPath => string.Format(@"{0}\{1}", ExePath, Properties.Settings.Default.ConfigPath);
        public static string OutFile => string.Format(@"{0}\{1}", ExePath, Properties.Settings.Default.OutFile);
    }
}
