using Microsoft.Win32;
using System;
using System.IO;
using System.Windows.Forms;

namespace Timetable
{
    internal static class Program
    {
        public static string appdata = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\Timetable";

        // Open the registry key and retrieve the last modified date for the Timetable, or set it.
        public static string TimetableModified
        {
            get
            {
                try
                {
                    var rk = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Timetable", true).GetValue("TimetableLastModified");
                    return $"Last changed: {(rk == null ? "Never" : (string)rk)}";
                }
                catch
                {
                    return "Last changed: Never";
                }
            }
            set
            {
                Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Timetable", true).SetValue("TimetableLastModified", DateTime.Now.ToString("dd/MM/yyyy @ hh:mm tt"));
            }
        }

        // Open the registry key and retrieve the last modified date for the class list, or set it.
        public static string ClassListModified
        {
            get
            {
                try
                {
                    var rk = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Timetable", true).GetValue("ClassListLastModified");
                    return $"Last changed: {(rk == null ? "Never" : (string)rk)}";
                }
                catch
                {
                    return "Last changed: Never";
                }
            }
            set
            {
                Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Timetable", true).SetValue("ClassListLastModified", DateTime.Now.ToString("dd/MM/yyyy @ hh:mm tt"));
            }
        }

        // Launch first time setup if either the class list or timetable image is missing.
        // Otherwise, launch the Timetable view.
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            if (!Directory.Exists(appdata))
                Directory.CreateDirectory(appdata);

            if (!File.Exists($@"{appdata}\timetable.png") || !File.Exists($@"{appdata}\classList.png"))
                Application.Run(new FTS());
            Application.Run(new View());
        }
    }
}
