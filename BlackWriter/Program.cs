using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace BlackWriter
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-DE");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
