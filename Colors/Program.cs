using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colors
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] parameters)
        {   
            if (!Directory.Exists(AppIo.RootPath))
            {
                Directory.CreateDirectory(AppIo.ConfigPath);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ColorPickerForm form = null;
            try
            {
                string p1, p2, p3;
                try
                {
                    p1 = parameters[0];
                    p2 = parameters[1];
                    p3 = parameters[2];
                }
                catch
                {
                    p1 = null;
                    p2 = null;
                    p3 = null;
                }

                if (p3 != null)
                {
                    int red, green, blue;

                    bool rint = int.TryParse(p1, out red);
                    bool gint = int.TryParse(p2, out green);
                    bool bint = int.TryParse(p3, out blue);

                    if (rint && gint && bint)
                        form = new ColorPickerForm(red, green, blue);
                    else
                        form = new ColorPickerForm();
                }
                else if (!string.IsNullOrWhiteSpace(parameters[0]) && parameters[0].Trim().ToLower() == "/party")
                    form = new ColorPickerForm(true);
                else form = new ColorPickerForm();
            }
            catch
            {
                form = new ColorPickerForm();
            }

            Application.Run(form);
        }
    }
}
